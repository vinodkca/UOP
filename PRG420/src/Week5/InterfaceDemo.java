/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week5;
interface Animal {

   public void eat();
   public void travel();
}


public class InterfaceDemo implements Animal{

   public void eat(){
      System.out.println("Mammal eats");
   }

   public void travel(){
      System.out.println("Mammal travels");
   } 

   public int noOfLegs(){
      return 0;
   }

   public static void main(String args[]){
      InterfaceDemo m = new InterfaceDemo();
      m.eat();
      m.travel();
   }
} 
