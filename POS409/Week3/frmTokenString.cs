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
    public partial class frmTokenString : Form
    {
        public frmTokenString()
        {
            InitializeComponent();
            ClearControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        //Explain void
        private void ClearControls()
        {
            txtInputString.Clear();
            txtOutputString.Clear();
            //txtTokenList.Clear();
        }

        private void btnSimpleGenerate_Click(object sender, EventArgs e)
        {
            string strCommaSepList = "Grade,A,B,C,D";
            string[] strCommanSepArray = strCommaSepList.Split(',');
            //string[] strCommanSepArray =  TokenString.SplitString(strCommaSepList,new char[]{','});
            foreach (string strValue in strCommanSepArray)
            {
                txtOutputString.Text += strValue.Trim() + Environment.NewLine; //"\r\n";
            }
        }

        //:;| //no space
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Name : Jim ; Andrew | Email : jim@email.com ; andrew@email.com |
            //:;| //no space
            string strInput = txtInputString.Text;

            //-This is C# code
            //String st = "MyBook"; |  int x =10;
            //-|
            string strToken = txtTokenList.Text;

            //Comma seperated
            string[] strTokens = TokenString.SplitString(strInput, strToken.ToCharArray());

            foreach (string strValue in strTokens)
            {
                txtOutputString.Text += strValue.Trim() + Environment.NewLine; //"\r\n";
            }
        }
    }
}
