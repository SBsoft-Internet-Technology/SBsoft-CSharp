using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayServer
{
    public class GV
    {
        public static String MainTipsMessage = "";
        public static string MainTips
        {
            get { return MainTipsMessage; }
            set { MainTipsMessage = value; }
        }
    }
}
