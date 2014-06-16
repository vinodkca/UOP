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
    public partial class fmPassByRef : Form
    {
        //Struct on stack
        ListCollection lstName;

        public fmPassByRef()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
             // Declare some local int variables.
             int x = 50, y = 100;

             // Display the values in those variables.
             lstOutput.Items.Clear();

             lstOutput.Items.Add("x is set to " + x);  
             // Pass each variable to SetToZero.
             SetToZeroBYRef(ref x);

             lstOutput.Items.Add("x is set to " + x);
            
             // Display the values in those variables again.
             lstOutput.Items.Add("--------------------");
             
             //Out variable doe snot need to be initialized
             //Usually local variables need to be initialized
             int myVar;
             //lstOutput.Items.Add("y is set to " + myVar);
             SetToZeroByOut(out myVar);
             lstOutput.Items.Add("y is set to " + myVar);
        }

         // The SetToZero method accepts an int argument
         // by reference and sets it to zero.
         private void SetToZeroBYRef(ref int number)
         {
             number = 250;
         }

         private void SetToZeroByOut(out int number)
         {
             number = 300;
         }

         private void DisplayList()
         {
             lstOutput.Items.Clear();
                        
             //If u do not assign variable struct does not work
             lstName.nameList = new List<string>();             
             //lstName.CreateList();Error:Use of unassigned local variable 'lstName' 

             lstName.nameList = lstName.CreateList();
             lstOutput.Items.AddRange(lstName.nameList.ToArray());
             //foreach (var item in lstName.nameList)
             //{
             //    lstOutput.Items.Add(item);
             //}

         }

        //Optional
         private void btnDisplay_Click(object sender, EventArgs e)
         {
             DisplayList();

             //Optional
             //DisplayRemove();
         }

         private void DisplayRemove()
         {
             lstOutput.Items.Clear();
             lstName.RemoveList("Chris");
             lstName.RemoveList(0);
             lstOutput.Items.AddRange(lstName.nameList.ToArray());
         }
    }
}

//Page 447
