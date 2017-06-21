using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MySchool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new AboutUs()); 
            //Application.Run(new StudentMsgFrm());
            //Application.Run(new CourseMsgFrm());
            //Application.Run(new CourseFrm());
            //Application.Run(new ScoreMsgFrm());
            Application.Run(new MainFrm());
        }
    }
}
