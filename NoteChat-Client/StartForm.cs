using NoteChat_Client.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteChat_Client
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            
        }

        private void IsSecretCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (IsSecretCbx.Checked == true)
            {
                SecretTxt.Enabled = true;
            }
            else { SecretTxt.Enabled = false;}
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if((IsSecretCbx.Checked == true && SecretTxt.Text == String.Empty) || ServerIPTxt.Text == String.Empty || ServerPortTxt.Text == String.Empty) {
                TipHelper.ShowWarning("请检查消息是否填写完成！");
                return;
            }
            GV.ServerIP = ServerIPTxt.Text;
            Console.WriteLine(GV.ServerIP);
            try
            {
                string strNumber = ServerPortTxt.Text;
                int result = int.Parse(strNumber);
                GV.ServerPort = result;
                Console.WriteLine(result.ToString());
            }
            catch (FormatException ex)
            {
                TipHelper.ShowError($"Error: {ex.Message}");
            }
            GV.Secret = SecretTxt.Text;
            GV.UserName = UsernameTxt.Text;
            ConfigHelper.SaveConfig("Connection", "LastServer", GV.ServerIP);
            ConfigHelper.SaveConfig("Connection", "LastServerPort", GV.ServerPort.ToString());
            if(IsSecretCbx.Checked == true)
            {
                ConfigHelper.SaveConfig("Connection", "LastSecret", GV.Secret);
            }
            else
            {
                ConfigHelper.SaveConfig("Connection", "LastSecret", "");
            }
            
            ConfigHelper.SaveConfig("Connection", "LastUsername", GV.UserName);
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            ConfigHelper.CreateDefaultConfig();
            LoadLocalConfig();
            
        }
        private void LoadLocalConfig()
        {
            GV.ServerIP = ConfigHelper.LoadConfig("Connection", "LastServer");
            GV.ServerPort = int.Parse(ConfigHelper.LoadConfig("Connection", "LastServerPort"));
            
            GV.Secret = ConfigHelper.LoadConfig("Connection", "LastSecret");
            GV.UserName = ConfigHelper.LoadConfig("Connection", "LastUsername");
            ServerIPTxt.Text = GV.ServerIP;
            ServerPortTxt.Text = GV.ServerPort.ToString();
            if(GV.Secret != string.Empty)
            {
                IsSecretCbx.Checked = true;
                SecretTxt.Text = GV.Secret;
            }
            UsernameTxt.Text = GV.UserName;
        }

        private void StartForm_Shown(object sender, EventArgs e)
        {
            TipHelper.ShowTip("欢迎使用NoteChat\n由xiaojiang233编写，SBsoft发行\n更新日志：\n1.修复一些bug，优化细节\n2.增加了配置文件，可以保存上一次连接信息\n3.制作了菜单，拥有了更多功能");
        }
    }
}
