﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Week4
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
            //Application.Run(new frmOOPS());
            //Application.Run(new frmPhoneBook());

            Application.Run(new frmDVPhoneBook());
            
        }
    }
}
