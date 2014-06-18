package Week2;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author vinodk
 */
public class DataTypes 
{
    //Primitive Data Types
    //Byte data type is an 8-bit signed two's complement integer.
    //Minimum value is -128 (-2^7)//
    //Maximum value is 127 (inclusive)(2^7 -1)
    //Default value is 0//
    //Byte data type is used to save space in large arrays, mainly in place of integers, since a byte is four times smaller than an int.
    //Example: byte a = 100 , byte b = -50
    
    //Short data type is a 16-bit signed two's complement integer. 
    //Minimum value is -32,768 (-2^15)//
    //Maximum value is 32,767 (inclusive) (2^15 -1)//
    //Short data type can also be used to save memory as byte data type. A short is 2 times smaller than an int
    //Default value is 0.
    //Example: short s = 10000, short r = -20000


    //Int data type is a 32-bit signed two's complement integer.
    //Minimum value is - 2,147,483,648.(-2^31)
    //Maximum value is 2,147,483,647(inclusive).(2^31 -1)
    //Int is generally used as the default data type for integral values unless there is a concern about memory.
    //The default value is 0.
    //Example: int a = 100000, int b = -200000

    //Long data type is a 64-bit signed two's complement integer. 
    //Minimum value is -9,223,372,036,854,775,808.(-2^63)
    //Maximum value is 9,223,372,036,854,775,807 (inclusive). (2^63 -1)
    //This type is used when a wider range than int is needed.
    //Default value is 0L.
    //Example: long a = 100000L, int b = -200000L
  
    //Float data type is a single-precision 32-bit IEEE 754 floating point. 
    //Float is mainly used to save memory in large arrays of floating point numbers.
    //Default value is 0.0f.
    //Float data type is never used for precise values such as currency. 
    //Example: float f1 = 234.5f

    //double data type is a double-precision 64-bit IEEE 754 floating point.
    //This data type is generally used as the default data type for decimal values, generally the default choice.     
    //Double data type should never be used for precise values such as currency.    
    //Default value is 0.0d.    
    //Example: float  d1 = (float)123.4;

    //boolean data type represents one bit of information.
    //There are only two possible values: true and false.
    //This data type is used for simple flags that track true/false conditions.
    //Default value is false.
    //Example: boolean one = true

    //char data type is a single 16-bit Unicode character. 
    //Minimum value is '\u0000' (or 0).
    //Maximum value is '\uffff' (or 65,535 inclusive).
    //Char data type is used to store any character.
    //Example: char letterA ='A'
  
    /*
    static byte a = 100;
    static short s = 10000;
    static int i = 100000;
    static long l = 100000;
    static float f = (float) 234; //or 234.5f
    static double d = (double) 25;
    static boolean b = true;
    static char letterA = 'A';
    */
    
    //Default values //For numbers, the default value is 0; for Booleans, it is false; and for object references, it is null.
    static byte a;    
    static short s ;
    static int i;
    static long l;
    static float f; //float b= 3.6; gives error  when you type a decimal number as 3.6, its interpreted as a double slution use (float) or 3.6f
    /*Important setting precision for float values float myFloat = 125.0f;   
    System.out.printf("%3.2f", myFloat);   "printf" method, which is taking a floating-point specifier (%f) as an argument along with the float value*/
    static double d; //double d = 3.0d;
    static boolean b;
    
    static String StringA ;
    
    
    
    /*
     How to Round
    To get a String:

            String.format("%.2f", 1.2399) // returns "1.24"
            String.format("%.3f", 1.2399) // returns "1.240"
            String.format("%.2f", 1.2) // returns "1.20"
    To print to standard output (or any PrintStream):

            System.out.printf("%.2f", 1.2399) // same syntax as String.format()
    If you don’t want trailing zeroes:

            new DecimalFormat("0.00").format(1.2)// returns "1.20"
            new DecimalFormat("0.##").format(1.2)// returns "1.2"

     
     */
    static char letterA ='A';
    public static void main(String[] args)
    {   
        //char letterA ='B';
        //System.out.println("Character " + DataTypes.letterA);
        //System.out.println("String " + StringA);
       primitiveDataTypes();
       stackandHeap();
    }   
    
    static void primitiveDataTypes()
    {   
        System.out.println("\n");
        System.out.println("byte " + a);
        System.out.println("short " + s);
        System.out.println("int " + i);
        System.out.println("long " + l);
        System.out.println("float " + f);
        System.out.println("double " + d);
        System.out.println("boolean " + b);
        System.out.println("letterA " + letterA);
    }
    
    //Local variables:
    //Local variables are declared in methods, constructors, or blocks.
    //Local variables are created when the method, constructor or block is entered and the variable will be destroyed once it exits the method, constructor or block.
    //Access modifiers cannot be used for local variables
    //Local variables are visible only within the declared method, constructor or block.
    //Local variables are implemented at stack level internally.
    //There is no default value for local variables so local variables should be declared and an initial value should be assigned before the first use.
    
    //Instance variables:
    //Instance variables are declared in a class, but outside a method, constructor or any block.
    //When a space is allocated for an object in the heap, a slot for each instance variable value is created.    
    //Instance variables are created when an object is created with the use of the keyword 'new' and destroyed when the object is destroyed.    
    //Instance variables hold values that must be referenced by more than one method, constructor or block, or essential parts of an object's state that must be present throughout the class.    
    //Instance variables can be declared in class level before or after use.    
    //Access modifiers can be given for instance variables.    
    //The instance variables are visible for all methods, constructors and block in the class. Normally, it is recommended to make these variables private (access level). However visibility for subclasses can be given for these variables with the use of access modifiers.    
    //Instance variables have default values. For numbers the default value is 0, for Booleans it is false and for object references it is null. Values can be assigned during the declaration or within the constructor.    
    //Instance variables can be accessed directly by calling the variable name inside the class. However within static methods and different class ( when instance variables are given accessibility) should be called using the fully qualified name . ObjectReference.VariableName.

    // Class/static variables:
    //Class variables also known as static variables are declared with the static keyword in a class, but outside a method, constructor or a block. 
    //There would only be one copy of each class variable per class, regardless of how many objects are created from it.
    //Static variables are rarely used other than being declared as constants. Constants are variables that are declared as public/private, final and static. Constant variables never change from their initial value.
    //Static variables are stored in static memory. It is rare to use static variables other than declared final and used as either public or private constants.
    //Static variables are created when the program starts and destroyed when the program stops.
    //Visibility is similar to instance variables. However, most static variables are declared public since they must be available for users of the class.
    //Default values are same as instance variables. For numbers, the default value is 0; for Booleans, it is false; and for object references, it is null. Values can be assigned during the declaration or within the constructor. Additionally values can be assigned in special static initializer blocks.
    //Static variables can be accessed by calling with the class name . ClassName.VariableName.
    //When declaring class variables as public static final, then variables names (constants) are all in upper case. If the static variables are not public and final the naming syntax is the same as instance and local variables.


    private static void stackandHeap()
    { 
        //Local Variables Local variables are visible only within the declared method, constructor or block.Local variables are implemented at stack level internally.
        int a, b, c;         // declares three ints, a, b, and c.
        int d = 3, e, f = 5; // declares three more ints, initializing d and f.
        byte z = 22;         // initializes z.
        double pi = 3.14159; // declares an approximation of pi.
        char x = 'x';        // the variable x has the value 'x'.
        
        System.out.println("Z is : " + z);    
        
        //Instance variables
        Employee empOne = new Employee("Ransika");
        empOne.setSalary(1000);
        empOne.printEmp();
        
        //Static Variables
        
        Department.salary = 1000;
        System.out.println(Department.DEPARTMENT +"average salary:"+Department.salary);

    }  
}