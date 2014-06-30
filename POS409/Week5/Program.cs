using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Week5
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
            //Application.Run(new frmDisplayAuthors());
            //Application.Run(new frmDisplayQuery());
            Application.Run(new frmMasterDetail());
        }
    }
}


/*
 
 Steps
  1.Create a Week5 Project
  2.Change the from to frmDisplayAuthors and add new folder Databases.Right click on the folder Add new Item -> Service Database -.Books.mdf
 *3.Double Click Books.mdf and it opens (Add a DataBase. View > Other Windows > Database Explorer to display the Database Explorer window.
  OR View->Server Explorer)
 * 4.Add Tables Author,AutorISBn,Title
 
 
 */