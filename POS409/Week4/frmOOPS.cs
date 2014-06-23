using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//OOPS - Object Oriented Programming System
//Poly morphism (Many forms) is one of the principle of object oriented programming.
//"Poly" means many and "morph" means forms hence the name polymorphism. Polymorphism also refered to as one name many forms or having one name with multiple functionality.
//In simple words you can use 
//same method name with different signature (STATIC Polymorphism or Compile Time polymorphism) or 
//same signature but in different class() (DYNAMIC Polymorphism or Runtime Time polymorphism).
//So depending on a data type it processes objects differently and an ability to redefine methods for a derived classes.

//Inheritance and Polymorphism
//Base and drived class
//Polymorphism
//Overriding Properties
//abstract class
//sealed class

namespace Week4
{
    public partial class frmOOPS : Form
    {
        public frmOOPS()
        {
            InitializeComponent();
        }

        private void btnPolymorphism_Click(object sender, EventArgs e)
        {
            txtPolymorphism.Text = string.Empty;

             //Dynamic polymorphism or run time polymorphism
             Shape objShape1 = new Circle();
             //properties
             txtPolymorphism.Text += String.Format("Description of a Circle is - {0}\r\n", objShape1.Message);
             objShape1.Description = "Example of Circle class";

             Shape objShape2 = new Sphere();
             txtPolymorphism.Text += String.Format("Description of a Sphere is - {0}\r\n", objShape2.Message);
             objShape2.Description = "Example of Sphere class";

             txtPolymorphism.Text += String.Format("Radius of a Circle is - {0}\r\n" , objShape1.getArea());
             txtPolymorphism.Text += String.Format("Radius of a Sphere is - {0}\r\n", objShape2.getArea());

             //Static polymorphism or compile time polymorphism
             txtPolymorphism.Text += String.Format("Add(int) of a Shape is - {0}\r\n", objShape1.Add(10, 20));
             txtPolymorphism.Text += String.Format("Add(double) of a Shape is - {0}\r\n", objShape2.Add(10, 20, 30));

             //abstract method
             txtPolymorphism.Text += String.Format("Circumference of a Circle is - {0}\r\n", objShape1.Circumference());
             txtPolymorphism.Text += String.Format("Circumference  of a Sphere is - {0}\r\n", objShape2.Circumference());

             //properties
             txtPolymorphism.Text += String.Format("Description of a Circle is - {0}\r\n", objShape1.Description);
             txtPolymorphism.Text += String.Format("Description of a Sphere is - {0}\r\n", objShape2.Description);

        }
    }
}

//select new item service database
//Press cancel to create mdf
//Enter column Information
//Let’s review what you have done up to this point:
//• Created a SQL Server database named Phonelist.mdf
//• Designed and created a table named Person
//• Entered sample data into the table
//The Database File’s Location //Week4\PhoneBook.mdf


//Completing the Phone Book Application
//Make sure the Phone Book project is open in Visual Studio
//Click Data on the Visual Studio menu -> Add New Data Source....
//Select Phone.mdf and 
//Data-show Datasource
//Then, click the down arrow ( ), and select DataGridView 

//Add the form and then you can select grodview
//Change to detailview

//Customize 
//Product Lookup Application
//Select the ListBox control. In the Properties window, select the DataSource property
//and then click the down arrow ( ) that appears next to it. In the list that
//pops up, expand Other Data Sources, then expand Project Data Sources, then
//expand ProductDataSet, and then select Product. This is shown in Figure 11-56.

//LIST BOX->PROPERTIES->DATASOURCE = "phoneBindingSource"->DataMember ->"Name"

//Right click data set add SearchByName and specify query and check fill and uncheck return datatable
//Pg 705