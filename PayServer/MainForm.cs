using PayServer.Managers;
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

namespace PayServer
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            GV.MainTips = "加载完成";
            Console.WriteLine(Application.StartupPath);
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
                toolStripTipsLabel.Text = "提示信息：" + GV.MainTips;
            }

        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                try {
                    
                    try
                    {
                        Environment.Exit(0);
                    }
                    catch { }
                }
                catch(Exception ex) { }
                

            }
            else
            { e.Cancel = true; }
        }
        private ShopSystemHelper shopSystemHelper;
        private void RefreshProductsBtn_Click(object sender, EventArgs e)
        {
            shopSystemHelper = new ShopSystemHelper(Application.StartupPath);
            shopSystemHelper.LoadDataIntoDataGridView(ProductDataGridView);
        }

        private void ApplyProductsBtn_Click(object sender, EventArgs e)
        {
            shopSystemHelper.SaveChanges(ProductDataGridView);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProductsBTN_Click(object sender, EventArgs e)
        {
            shopSystemHelper.DeleteSelectedProduct(ProductDataGridView);
        }
    }
}
