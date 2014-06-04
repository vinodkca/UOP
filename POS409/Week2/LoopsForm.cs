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
    public partial class frmLoops : Form
    {
        public frmLoops()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearControl()
        {
            lstLoop.Items.Clear();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            ClearControl();
            /* local variable definition */
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                lstLoop.Items.Add(String.Format("while of a: {0}", a));
                a++;
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            ClearControl();
            /* for loop execution */
            for (int a = 20; a > 10; a = a - 1)
            {
                lstLoop.Items.Add(String.Format("for of a: {0}", a)); 
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            ClearControl();
            /* local variable definition */
            int a = 10;

            /* do loop execution */
            do
            {
                lstLoop.Items.Add(String.Format("do while of a: {0}", a)); 
                a = a + 1;
                //continue; //goes to end ??
                //break;
            } while (a < 20);
        }

        private void btnInfinite_Click(object sender, EventArgs e)
        {
            ClearControl();
            for (; ; )
            {
                lstLoop.Items.Add("Hey! I am Trapped");
                break;
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            ClearControl();
            double[] balance = { 2340.0, 4523.69, 3421.0 };
            //int[] marks = new int[] { 99, 98, 92, 97, 95 };
            int[] marks = { 99, 98, 92, 97, 95 };
            int[] score = marks;

            /* output each array element's value */
            //for (int j = 0; j < score.Length; j++)
            //{
            //    lstLoop.Items.Add(String.Format("array of a: {0}", score[j])); 
            //}

            foreach (int val in score)
            {
                lstLoop.Items.Add(String.Format("array of a: {0}", val)); 
            }
        }

        //Example of Collection
        //Unlike array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. 
        //It also allow dynamic memory allocation, adding, searching and sorting items in the list
        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            //"Adding some numbers:"
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
            //al.Add(92); //adding these two element increases the Capacity from 8 to 16
            //al.Add(91);
            ClearControl();
            lstLoop.Items.Add(String.Format("Capacity: {0} ", al.Capacity));
            lstLoop.Items.Add(String.Format("Count: {0}", al.Count));

            //Sort the list
            al.Sort();
            foreach (int i in al)
            {
                lstLoop.Items.Add(String.Format("{0}",i));
            }
        }
    }
}
