using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayServer.Managers
{
    public class Helper
    {
        public static void ShowError(string message)
        {
            Console.WriteLine("出现错误:" + message);
            MessageBox.Show("出现错误：" + message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
