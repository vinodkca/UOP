using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace POS409
{
    public partial class frmExternalApp : Form
    {
        public frmExternalApp()
        {
            InitializeComponent();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "NOTEPAD.EXE";
            startInfo.Arguments = txtTextFile.Text;
            Process.Start(startInfo);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = txtTextFile.Text;
            Process.Start(startInfo);

            /*If you want to wait till the external app close like modal dialog*/
            /*try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }*/

        }


        static void SearchGoogle(string t)
        {
            Process.Start("http://google.com/search?q=" + t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchGoogle(txtWebBrowser.Text);
        }

        //Process.Start("Chrome.exe", "http://www.bing.com/search?q=C%23+examples");
        //Process.Start("IExplore.exe", "www.microsoft.com");

    }
}
