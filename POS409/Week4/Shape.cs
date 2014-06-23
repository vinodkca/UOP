using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    //During run time, Method overriding can be achieved by using INHERITANCE principle 
    //and using "virtual" and "override" keyword. 
    //public class Shape
    public abstract class Shape
    {

        public Shape()
        {
            Message += "Shape Default Contructor -> ";
        }

        public Shape(string strvalue)
        {
            Message += strvalue + "Shape Contructor with value -> ";
        }

        public int radius = 5;

        public virtual double getArea()
        {
            return 0;
        }
        
        //2.Method Overloading
         public int Add(int a, int b)  
         {  
             return a + b;  
         }  

         public double Add(int z, int x, int c)  
         {  
             return z + x + c;  
         }

        //3. The purpose of abstract class is to provide default functionality to its sub classes.
        //When a class is declared as abstract class, then it is not possible to create an instance for that class. 
        //But it can be used as a parameter in a method.
        //U willneed to declare class as abstract
         public abstract double Circumference();

        //4. sealed CLASS
        //A sealed class cannot be used as a base class. 
        //sealed keyword before the override keyword in the class member declaration fucntion. 
        // public sealed virtual void DoWork() { }     
        
        //5. Setting properties in class
         private string desc;

         public string Description
         {
             get { return desc; }
             set { desc = value; }
         }

         //6. Constructor Message
         private string msg;

         public string Message
         {
             get { return msg; }
             set { msg = value; }
         }

    }


 
    public class Circle : Shape
    {
        public Circle(): base("Base ")
        {
           
            Message += "Circle Contructor";

        }

        public Circle(string strvalue)
        {
            Message += "Circle Contructor with value -> ";
        }


        //1.Method overriding
        public override double getArea()
        {
            return 3.14 * radius * radius;
        }

        //abstract fucntion need to be overridden
        public override double Circumference()
        {
            return 2 * 3.14 * radius;

        }

        //public override void DoWork() { }
    }

    public class Sphere : Shape
    {
        public Sphere(): base("Base ")
        {            
            Message += "Sphere Contructor";
        }

        public Sphere(string strvalue)
        {
            Message += "Sphere Contructor with value -> ";
        }

        public override double getArea()
        {
            return 4 * 3.14 * radius * radius;
        }

        //abstract fucntion need to be overridden
        public override double Circumference()
        {
            return 2 * 3.14 * radius; // 2 pie r

        }       
        
    }
    
}
