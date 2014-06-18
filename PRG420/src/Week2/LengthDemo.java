//Modifiers are keywords that you add to those definitions to change their meanings. The Java language has a wide variety of modifiers, including the following:
//Java Access Modifiers
//Java provides a number of access modifiers to set access levels for classes, variables, methods and constructors. The four access levels are:
//Visible to the package, the default. No modifiers are needed.
//Visible to the class only (private).
//Visible to the world (public).
//Visible to the package and all subclasses (protected).

//Non Access Modifiers
//Java provides a number of non-access modifiers to achieve many other functionality.
//The static modifier for creating class methods and variables
//The final modifier for finalizing the implementations of classes, methods, and variables.
//The abstract modifier for creating abstract classes and methods.
//The synchronized and volatile modifiers, which are used for threads.
package Week2;

/**
 *
 * @author vinodk
 */
public class LengthDemo
{
   public static void main(String[] args)
   {
      Rectangle box = new Rectangle();

      System.out.println("Sending the value 10.0 to "
                         + "the setLength method.");
      box.setLength(10.0);
      System.out.println("Done.");
   }
}
