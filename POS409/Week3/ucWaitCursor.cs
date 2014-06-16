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
    public partial class ucWaitCursor : UserControl
    {
        public ucWaitCursor()
        {
            InitializeComponent();
        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            int milliSecondsToWait = (int)updwnWait.Value * 1000;
            System.Threading.Thread.Sleep(milliSecondsToWait);

            Cursor.Current = Cursors.Default;
        }
    }
}
