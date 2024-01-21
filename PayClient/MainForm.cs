using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Thread Tthread = new Thread(SetTimeLabelThread);
            Tthread.Start();
        }
        private void SetTimeLabelThread()
        {
            DateTime time;
            while (true)
            {
                time = DateTime.Now;
                toolStripStatusTimeLabel.Text = "当前时间：" + time.GetDateTimeFormats('f')[0].ToString() + ":" + time.Second.ToString();
            }
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("是否退出？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
            else
            { e.Cancel = true; }
        }
        private void ExitProcess()
        {
            
        }
    }
}
