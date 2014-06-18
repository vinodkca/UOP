/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week4;

/**
 *
 * @author vinodk
 */
public class StringBuilderDemo {
    public static void main(String[] args) {
        //StringBuilder class is that you cannot use the assignment operator
        //to assign strings to StringBuilder objects. For example, the following code will not work:
        //StringBuilder city = "Charleston"; // ERROR!!! Will not work!
        
        
        StringBuilder city = new StringBuilder("Charleston");
        System.out.println(city);
        
        StringBuilder str = new StringBuilder();
        // Append values to the object.
        str.append("We sold 12 doughnuts for $"); // Append a String object.        
        str.append(15.95); // Append a double.        
        System.out.println(str);
        
        //str = new StringBuilder("New City");
        str.insert(0, "In this City ");
        System.out.println(str);
        

         str.replace(3, 12, "Fresno"); //Replace In this City 
        System.out.println(str);

        str.delete(0, 13); //remove In fresno
        System.out.println(str);            
    }
}
