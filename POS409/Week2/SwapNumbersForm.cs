using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Week2
{
    //Class Activity Week2
    public partial class frmSwapNumbers : Form
    {
        public frmSwapNumbers()
        {
            InitializeComponent();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            ArrayList alListA = new ArrayList();
            ArrayList alListB = new ArrayList();

            for (int i = 0; i < lstA.Items.Count; i++)            {
                int x = Convert.ToInt32(lstA.Items[i]);
                int y = Convert.ToInt32(lstB.Items[i]);
                SwapNum(ref x, ref y);
                alListA.Add(x);
                alListB.Add(y);
            }

            lstA.DataSource = alListA;
            lstA.SelectedIndex = -1;
                        
            lstB.DataSource = alListB;
            lstB.SelectedIndex = -1;

        }
      
        void SwapNum(ref int x, ref int y)  
        {    
            int tempswap = x;  
            x = y;  
            y = tempswap;              
        }

        private void btnSwapNumber_Click(object sender, EventArgs e)
        {
            int iSelIndexA = lstA.SelectedIndex;
            int iSelIndexB = lstB.SelectedIndex;

            if(iSelIndexA > -1 && iSelIndexB > -1)
            {
                int x = Convert.ToInt32(lstA.SelectedItem);
                int y = Convert.ToInt32(lstB.SelectedItem);
                SwapNum(ref x, ref y);

                lstA.Items.RemoveAt(iSelIndexA);
                lstA.Items.Insert(iSelIndexA,x);
                
                lstB.Items.RemoveAt(iSelIndexB);
                lstB.Items.Insert(iSelIndexB, y);
            }
        } 
    }
}
