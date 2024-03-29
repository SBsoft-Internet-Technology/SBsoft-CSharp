﻿using NoteChat_Client.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteChat_Client
{
    public partial class MainForm : Form
    {   
        public MainForm()
        {
            InitializeComponent();
            toolTip1.SetToolTip(SendMessageRTxt, "消息不能为空");
        }
        private TcpClientThread tcpClientThread;
        private void MainForm_Load(object sender, EventArgs e)
        {
            tcpClientThread = new TcpClientThread(GV.ServerIP,GV.ServerPort , GV.Secret, MessageRtxt,OnlineListBox);
            tcpClientThread.Connect();

            // 启动一个线程用于接收消息
            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessages));
            receiveThread.Start();
            tcpClientThread.SendMessage("Auth:" + GV.UserName);
            tcpClientThread.FetchOnlineList();
            this.Text = "NoteChat-2.0 | " + GV.UserName;
            toolStripStatusLabel3.Text = "On the " + GV.ServerIP + ":" + GV.ServerPort.ToString();
            Thread Timethread = new Thread(SetTimeLabel);
            Timethread.Start();

        }

        private void SetTimeLabel()
        {
            DateTime time;
            while(true)
            {
                time = DateTime.Now;
                toolStripStatusLabel1.Text = "当前时间：" + time.GetDateTimeFormats('f')[0].ToString() + ":" + time.Second.ToString();
            }
            
        }
        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            if(SendMessageRTxt.Text != string.Empty)
            {
                tcpClientThread.SendMessage(SendMessageRTxt.Text);
                SendMessageRTxt.Clear();
            }
            else
            {
                toolTip1.Show("消息不能为空", SendMessageRTxt, 0, -20, 2000);
            }
            
        }
        private void ReceiveMessages()
        {
            while (true)
            {
                // 接收消息
                string receivedMessage = tcpClientThread.ReceiveMessage();
                if (!string.IsNullOrEmpty(receivedMessage))
                {
                    // 在 UI 线程中显示消息
                    Invoke(new MethodInvoker(() =>
                    {
                        MessageRtxt.AppendText(receivedMessage + Environment.NewLine);
                    }));
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult aaa = TipHelper.ShowQuestion("您真的要退出吗？", MessageBoxButtons.YesNo);
            if (aaa == DialogResult.Yes)
            {
                e.Cancel = false;
               
                tcpClientThread.Disconnect();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void RefreshListBox_Click(object sender, EventArgs e)
        {
            tcpClientThread.FetchOnlineList();
        }

        private void SendMessageRTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && SendMessageRTxt.Text != string.Empty) {
                tcpClientThread.SendMessage(SendMessageRTxt.Text);
                SendMessageRTxt.Clear();
            }
            else if(e.KeyCode == Keys.Enter){
                toolTip1.Show("消息不能为空", SendMessageRTxt, 0, -20, 2000);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }

    public class TcpClientThread
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private Thread receiveThread;
        private MainForm mainForm = new MainForm();
        private RichTextBox messageRtxt; // RichTextBox 控件
        private ListBox onlineListBox;
        public string ServerIP { get; private set; }
        public int ServerPort { get; private set; }
        public string EncryptionKey { get; private set; }
        
        public TcpClientThread(string serverIP, int serverPort, string encryptionKey, RichTextBox messageRtxt, ListBox onlineListBox)
        {
            ServerIP = serverIP;
            ServerPort = serverPort;
            EncryptionKey = encryptionKey;
            this.messageRtxt = messageRtxt;
            this.onlineListBox = onlineListBox;
            tcpClient = new TcpClient();
            receiveThread = new Thread(new ThreadStart(ReceiveData));
        }
        public async void FetchOnlineList()
        {
            try
            {
                await Task.Run(() =>
                {
                    // 发送Command:onlinelist命令
                    byte[] data = Encoding.UTF8.GetBytes("Command:onlinelist");
                    stream.Write(data, 0, data.Length);

                    // 异步执行接收在线列表
                    string onlineListMessage = ReceiveMessage();
                    if (onlineListMessage.StartsWith("List:"))
                    {
                        // 解析在线列表并添加到OnlineListBox中
                        string[] onlineUsers = onlineListMessage.Substring("List:".Length)
                            .Replace("'", "")  // 去掉单引号
                            .Replace("[", "")   // 去掉左方括号
                            .Replace("]", "")   // 去掉右方括号
                            .Split(',');

                        // 在 UI 线程上执行 ListBox 操作
                        onlineListBox.Invoke(new MethodInvoker(() =>
                        {
                            onlineListBox.Items.Clear();
                            onlineListBox.Items.AddRange(onlineUsers);
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                TipHelper.ShowError($"Error fetching online list: {ex.Message}");
            }
        }




        public void Connect()
        {
            try
            {
                tcpClient.Connect(ServerIP, ServerPort);
                stream = tcpClient.GetStream();
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                TipHelper.ShowError($"Error connecting to server: {ex.Message}");
            }
        }

        private void ReceiveData()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while (true)
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AppendMessageToRichTextBox(receivedMessage);
                }
            }
            catch (Exception ex)
            {
                TipHelper.ShowError($"Error receiving data: {ex.Message}");
            }
        }

        public string ReceiveMessage()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            catch (Exception ex)
            {
                TipHelper.ShowError($"Error receiving data: {ex.Message}");
                return null;
            }
        }



        private void AppendMessageToRichTextBox(string message)
        {
            if (messageRtxt.InvokeRequired)
            {
                messageRtxt.Invoke(new MethodInvoker(() => AppendMessageToRichTextBox(message)));
            }
            else
            {
                // 格式化消息并添加到 RichTextBox
                string formattedMessage = $"[{DateTime.Now.ToString("HH:mm:ss")}] {message}";
                messageRtxt.AppendText(formattedMessage + Environment.NewLine);

                // 将滚动条滑动到最下面
                messageRtxt.SelectionStart = messageRtxt.Text.Length;
                messageRtxt.ScrollToCaret();
            }
        }




        public void SendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                TipHelper.ShowError($"Error sending message: {ex.Message}");
            }
            string formattedMessage = $"[{DateTime.Now.ToString("HH:mm:ss")}] {message}";
            messageRtxt.AppendText(formattedMessage + Environment.NewLine);
        }

        public void Disconnect()
        {
            try
            {
                stream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                TipHelper.ShowError($"Error disconnecting: {ex.Message}");
            }
        }
    }
}
