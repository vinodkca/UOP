
package Week2;

public class Quiz {
     public static void main(String[] args) 
    {    
        String s  = "Programmer ";
        
        s.concat("String Object is IMMUTABLE");
        System.out.println(s);
        
        s = s.concat("String Object is IMMUTABLE");
        System.out.println(s);
        
        s += " String Object is IMMUTABLE";
        System.out.println(s);      
        
    }
}
