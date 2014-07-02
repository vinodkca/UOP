//http://flyingjxswithjava.blogspot.com/2014/02/copylibs-doesnt-support-excludefromcopy.html
//excludeFromCopy="${copylibs.excludes}"
//from build-impl.xml
package Week44;
//TestB class is accessible because it’s public. 
//Only public members of TestB class is accessible because TestC class is not in the same package nor it’s subclass of TestB.
public class TestC extends Week33.TestA{
    public static void main(String[] args) {
       //Week33.TestA aa = new Week33.TestA(); //calling non-static method in static method in Java only way
       //aa.methodPublic();
        // Week33.TestA.methodProtected(); //has protected access in TestA and not in same package
        //aa.methodDefault();//has protected access in TestA and not in same package
         
        
        
    }    
   
     void   doNow() 
     {
        Week33.TestA aa = new Week33.TestA();
        //aa.methodProtected(); // ERROR: tryMeProtected() has protected access in Class1
        methodProtected();  // No error  // accessible through inheritance in subclasses outside the package
    }  
}

/*
class test
{
    void message()
    {
        System.out.println("super class");
    }
}

class demo extends test
{
    int z;
    demo(int y)
    {
        super.message();
        z=y;
        System.out.println("re:"+z);
    }
    
    public void add(int x ,int y)
   {
      int a=x;
      int b=y;
      int c=a+b;
      System.out.println("addition"+c);

   }

}
class free{
    public static void main(String ar[]){
        demo d=new demo(6);
        d.add(10,20);     // to call the non-static method

    }
}
 */

//There are two ways to call a non static function from static function:
//1.Call the non-static method from an instance within the static method. See fabien's answer for an oneliner sample... although I would strongly recommend against it. With his example he creates an instance of the class and only uses it for one method, only to have it dispose of it later. I don't recommend it because it treats an instance like a static function. 
//2.Change the static method to a non-static. 
