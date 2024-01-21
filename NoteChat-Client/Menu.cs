using NoteChat_Client.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteChat_Client
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            if (listView1.SelectedItems[0].Index == 0)
            {
                Process.Start("https://ys.mihoyo.com");
                return;
            }
            if (listView1.SelectedItems[0].Index == 1)
            {
                Process.Start("https://github.com/SBsoft-Internet-Technology/SBsoft-CSharp/tree/master/NoteChat-Client");
                return;
            }
            if (listView1.SelectedItems[0].Index == 2)
            {
                DialogResult aaa = TipHelper.ShowQuestion("您真的要退出吗？", MessageBoxButtons.YesNo);
                if (aaa == DialogResult.Yes) {
                Environment.Exit(0);
                }
            }
            }
            catch(ArgumentOutOfRangeException ex) {TipHelper.ShowWarning("出现错误：" + ex.Message +"\n请选择一个选项");

        }
    }
}
