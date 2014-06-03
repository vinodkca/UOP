using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS409
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //Refractor-> Extract Method on menu
            //InitializeControls();
            lblErrUser.Visible = false;
            lblErrPassword.Visible = false;
            this.ActiveControl = btnExit;
        }

        private void InitializeControls()
        {
            lblErrUser.Visible = false;
            lblErrPassword.Visible = false;
            this.ActiveControl = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrUser.Visible =  false;
            lblErrPassword.Visible = false;                

            if (txtUserName.TextLength <= 0)
            {
                lblErrUser.Visible = true;                
            }

            if (txtPassword.TextLength <= 0)
            {
                lblErrPassword.Visible = true;                
            }

            //string.IsNullOrEmpty(Password))
            if (
                (txtUserName.TextLength > 0 && txtUserName.Text == "test") &&
                (txtPassword.TextLength > 0 && txtPassword.Text == "1234")
               )
            {
                MessageBox.Show("Logged in successfully.");
            }
            else
            {
                MessageBox.Show("Incorrect User/Password.");
            }

            /*Not required*/
            //if (string.Compare(dbPassword, appPassword) == 0)
            //{
            //    //Logged in
            //}
            //else
            //{
            //    //You may want to use the same error message so they can't tell which field they got wrong
            //    textBoxPassword.Focus();
            //}

        }
    }
}
