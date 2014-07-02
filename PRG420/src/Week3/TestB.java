package Week3;
//Try this combination in the Netbeans Editor: ctrl + shift + c =>Tools->Option->Keymap
//TestB is in the same package as TestA class and hence it is able to access it’s class members. 
//private members are not accessible but all other members are accessible because of the same package.
public class TestB {
 public static void main(String args[]){
     Week33.TestA aa = new Week33.TestA();
        aa.methodPublic();
        //aa.methodProtected(); //has protected access in TestA
        //aa.methodDefault(); // cannot be accessed from outside package
         
    }     
  
    
}
