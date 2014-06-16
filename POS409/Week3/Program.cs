using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Week3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Default arguements and void
            //Application.Run(new frmTokenString());

            //Passing Arguments by Reference (ref & out) 
            //out does not need to be initialized before calling but ref needs to be
            //Application.Run(new fmPassByRef());
            
            //User Controls
            Application.Run(new frmBusy());
        }
    }
}
