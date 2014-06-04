using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week1
{
    
//1.Enable the Tools → Settings → Expert Settings menu option


//2.Go to Tools → Options
// In the dialog box, check Show All Settings option in the bottom left.


//3.In the above dialog, now choose Projects and Solutions → General.
// Check the option Show advanced build configurations. (also say show output window when solution starts)

//4.Click OK.

//You should be able to see the Release/Debug options in the toolbar now.

    public partial class frmNames : Form
    {
        FileInfo fileinfo = new FileInfo();
        public frmNames()
        {
            InitializeComponent();
            this.ActiveControl = btnWrite;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            for (int i = 0; i < 10; i++)
            {
                lstNames.Items.Add("Employee " + i.ToString());   
            }            
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            //fileinfo.WriteFile(names, "names.txt"); 

            string[] names = new String[lstNames.Items.Count];
            for (int i = 0; i < lstNames.Items.Count; i++)
            {
                names[i] = lstNames.Items[i].ToString();
            }
            fileinfo.WriteFile(names, "names.txt");

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstNames.Items.Clear();
            }
            else
            {
                // user clicked no
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            string[] names =  fileinfo.ReadFile("names.txt");
            for (int i = 0; i < names.Length; i++)
            {
                lstNames.Items.Add(names[i].ToString());
            }
            MessageBox.Show("Read from file successfully !!!");
        }
    }
}
