/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week4;

import java.util.ArrayList;

/**
 *
 * @author vinodk
 */
public class ArrayListDemo {
    public static void main(String[] args)
   {
      // Create an ArrayList to hold some names.
      ArrayList<String> nameList = new ArrayList<String>();
      
      // Add some names to the ArrayList.
      nameList.add("James");
      nameList.add("Catherine");
      nameList.add("Bill");
      
     //System.out.println(nameList);

      // Display the items in nameList and their indices.
      for (int index = 0; index < nameList.size(); index++)
      {
         System.out.println("Index: " + index + " Name: " +
                            nameList.get(index));
      }
      
      // Now replace the item at index 1.
      nameList.set(1, "Becky");
      
      System.out.println("Catherine was replaced with Becky. " +
                         "Here are the items now.");
                         
      // Display the items in nameList and their indices.
      for (int index = 0; index < nameList.size(); index++)
      {
         System.out.println("Index: " + index + " Name: " +
                            nameList.get(index));
      }
      
       nameList.remove(2);
       System.out.println("Size of array " + nameList.size());
   }
    
    private static void SampleNumberArray()
    {
    // create an empty arraylist with an initial capacity
      ArrayList<Integer> arrlist = new ArrayList<Integer>(5);

      // use add() method to add elements in the list
      arrlist.add(15);
      arrlist.add(20);
      arrlist.add(25);
      arrlist.add(22);

      // let us print all the elements available in list
      for (Integer number : arrlist) {
        System.out.println("Number = " + number);
      }

      // this will print the size of this list
      int retval = arrlist.size();
      System.out.println("Size of list = " + retval); 
    }
}
