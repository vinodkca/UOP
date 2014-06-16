using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week3
{
    public partial class frmBusy : Form
    {
        public frmBusy()
        {
            InitializeComponent();

            /*Optional*/
            //this.Controls.Remove(ucWaitCursor1);
            //this.Controls.Remove(ucMarqueeProgress1);
            //this.Controls.Remove(ucRealProgressBar1);

            //for (int i = 0; i < 10; i++)
            //{
            //    ucWaitCursor ucwait1 = new Week3.ucWaitCursor();
            //    ucwait1.Location = new System.Drawing.Point(30,  i*50 );
            //    this.Controls.Add(ucwait1);    
            //}
            
        }
    }
}
