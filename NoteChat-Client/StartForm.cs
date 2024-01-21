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
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
