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
    public partial class ucMarqueeProgress : UserControl
    {
        public ucMarqueeProgress()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBarMarquee.Style = ProgressBarStyle.Marquee;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            progressBarMarquee.Style = ProgressBarStyle.Blocks;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            progressBarMarquee.Style = ProgressBarStyle.Marquee;
            backgroundWorkerMarquee.RunWorkerAsync();
        }

        private void backgroundWorkerMarquee_DoWork(object sender, DoWorkEventArgs e)
        {
            int milliSecondsToWait = (int)nupdwnMarquee.Value * 1000;
            System.Threading.Thread.Sleep(milliSecondsToWait);

            backgroundWorkerMarquee.ReportProgress(100);
        }

        private void backgroundWorkerMarquee_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarMarquee.Style = ProgressBarStyle.Blocks;
        } 
    }
}
