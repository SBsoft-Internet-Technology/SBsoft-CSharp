using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteChat_Client.Helper
{
    public class TipHelper
    {
        public static void ShowTip(string message)
        {
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowError(string message)
        {
            MessageBox.Show(message + "\n程序遇到了致命性错误，按下确定退出", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
        public static DialogResult ShowQuestion(string message,MessageBoxButtons boxButtons)
        {
            return MessageBox.Show(message, "请选择", boxButtons, MessageBoxIcon.Question);
        }
        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
