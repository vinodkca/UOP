using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Week1;

namespace POS409
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
            //Application.Run(new formLogin());
            //Application.Run(new formNames());
            Application.Run(new frmExternalApp());
        }
    }
}
