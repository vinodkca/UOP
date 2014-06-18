package Week5;
class SuperClass2
{
   // No-arg constructor
   public SuperClass2()
   {
      System.out.println("This is the superclass " +  "no-arg constructor.");
   }

   // Constructor #2
   public SuperClass2(int arg)
   {
      System.out.println("The following argument was " + "passed to the superclass " + "constructor: " + arg);
   }

   //Part 2
    public void showMe()
     {
          System.out.println("Function showMe on SuperClass2");
     }
    
    public void showMe(int i)
     {
          System.out.println("Function showMe on SuperClass2 " + i);
     }
   
}

class SubClass2 extends SuperClass2
{
   // Constructor   
   public SubClass2()
   {
      // Call the superclass constructor.
      //super();
      //super(10);
      
      // Display a message.
      System.out.println("This is the subclass " +  "constructor.");
   }
   
   //Part 2
//    public void showMe()
//     {
//          System.out.println("Function showMe on SubClass2");
//     }
    public void showValue(int arg)
   {
      System.out.println("SUBCLASS: The int " +
                         "argument was " + arg);
   }

   /**
    *  The following method overloads the base
    *  class methods.
    */

   public void showValue(double arg)
   {
      System.out.println("SUBCLASS: The double " +
                         "argument was " + arg);
   }
   
   public void showValue(String arg)
   {
      System.out.println("SUBCLASS: The string " +
                         "argument was " + arg);
   }

}

public class SuperSubDemo 
{
    public static void main(String[] args) {
        //Super
        SuperClass2 scmain = new SuperClass2();
        SubClass2 sc = new SubClass2();
        //Overriding -polymorphic
        SuperClass2 sc1 = sc;
        sc1.showMe();
        //Overloading
        sc1.showMe(20);
         if(sc instanceof SubClass2)
            System.out.println("sc is instance of SubClass2" );
          if(sc1 instanceof SubClass2)
            System.out.println("sc1 is instance of SuperClass2" );
          //??
           if(sc instanceof SuperClass2)
            System.out.println("sc is instance of SuperClass2" );
            if(sc1 instanceof SubClass2)
            System.out.println("sc1 is instance of SubClass2" );
              if(scmain instanceof SubClass2)
            System.out.println("scmain is instance of SubClass2" );
        
              SubClass2 myObject = new SubClass2();

      myObject.showValue(10);       // Pass an int.
      myObject.showValue(1.2);      // Pass a double.
      myObject.showValue("Hello");  // Pass a String.

        
        
    }
    
}