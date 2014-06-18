/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week3;

/**
 *
 * @author vinodk
 */

class Employee
{
   private String name;  
   
   public Employee(String name)
   {
      System.out.println("Constructing an Employee");
      this.name = name;        
   }
   
   public String getName()
   {
      return name;
   }
   
      //Overriding
   public void mailCheck()
   {
      System.out.println("MailCheck of Employee class ");
      System.out.println("Mailing a check to " + this.name );
   }
   
   //OverLoading
   public void mailCheck(String str)
   {
       
   }
  
}

class Salary extends Employee
{   
   public Salary(String name)
   {
       super(name);       
   }
   
   //final you cannot override ; all functiosn virtual by defualt
   public void mailCheck()
   {
       System.out.println("MailCheck of Salary class ");
       System.out.println("Mailing check to " + getName());
   }
}

public class JavaPolymorphism 
{
   public static void main(String [] args)
   {
       //child class can override a method in its parent with same function.
       //Parent cannot be cast to Child
      Salary s = new Salary("Salary One");
      Employee e = new Salary("Employee One");
      System.out.println();
      
      System.out.println("Call mailCheck using Salary reference --");
      s.mailCheck();
      
      System.out.println();
      System.out.println("Call mailCheck using Employee reference--");
      e.mailCheck();    
      
     
    }   
}


