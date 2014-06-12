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
        ArrayList alListA = new ArrayList();
        ArrayList alListB = new ArrayList();

        public frmSwapNumbers()
        {
            InitializeComponent();
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

                alListA.RemoveAt(iSelIndexA);
                iSelIndexA = iSelIndexA-1 <= 0 ? 0 : iSelIndexA-1;
                alListA.Insert(iSelIndexA + 1, x);
                lstA.DataSource = null;
                lstA.DataSource = alListA;
                lstA.SelectedIndex = -1;
                
                alListB.RemoveAt(iSelIndexB);
                iSelIndexB = iSelIndexB - 1 <= 0 ? 0 : iSelIndexB - 1;
                alListB.Insert(iSelIndexB +1, y);
                lstB.DataSource = null;
                lstB.DataSource = alListB;
                lstB.SelectedIndex = -1;

            }
        }

        private void btnSwapList_Click(object sender, EventArgs e)
        {
            alListA = new ArrayList();
            alListB = new ArrayList();
            for (int i = 0; i < lstA.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstA.Items[i]);
                int y = Convert.ToInt32(lstB.Items[i]);
                SwapNum(ref x, ref y);
                alListA.Add(x);
                alListB.Add(y);
            }
                        
            lstA.DataSource = null;
            lstA.DataSource = alListA;
            lstA.SelectedIndex = -1;
                       
            lstB.DataSource = null;
            lstB.DataSource = alListB;
            lstB.SelectedIndex = -1;
        } 
    }
}
