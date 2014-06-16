using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week3
{
    public partial class ucRealProgressBar : UserControl
    {
        public ucRealProgressBar()
        {
            InitializeComponent();
        }

        private void btnDoReal_Click(object sender, EventArgs e)
        {
            int totalWork = (int)nupdownReal.Value;

            for (int i = 1; i <= totalWork; i++)
            {
                int milliSecondsToWait = (int)nupdownTimeSec.Value;
                System.Threading.Thread.Sleep(milliSecondsToWait);

                int progress = i * 100 / totalWork;
                progressBarReal.Value = progress;
            }

            progressBarReal.Value = 0;
        }
    }
}
