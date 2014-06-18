package Week4;

import java.util.Arrays;

public class ArrayDemo 
{
   public static void main(String[] args)
   {  
       SortNumbers();
       //ArraySample();
      //ArrayInitialization();
       //Careful about invalid list
   }

   private static void ArraySample() 
   {    
       int[] sample = { 15, 18, 20, 22};

        // Display the days in each month.
        for (int i = 0; i < sample.length ; i++)
        {
           System.out.println("Sample data " +  sample[i]);
        }
        
   }
    private static void ArrayInitialization() 
    {    
        final int MONTHS = 12;  // Number of months
        
        // Create and initialize an array.
        int[] days = { 31, 28, 31, 30, 31, 30,
                       31, 31, 30, 31, 30, 31 };

        // Display the days in each month.
        for (int index = 0; index < MONTHS; index++)
        {
           System.out.println("Month " + (index + 1)
                 + " has " + days[index] + " days.");
        }
    }
    
   private static void SortNumbers() 
   {  
       int [] numbers = { 9, 2, 7, 12, 1 };

          // Display the array elements unsorted.
          for (int i = 0; i < numbers.length; i++)
               System.out.print(numbers[i] + " ");
          System.out.println();

          // Sort the array.
          Arrays.sort(numbers);

          // Display the array elements sorted.
          for (int i = 0; i < numbers.length; i++)
               System.out.print(numbers[i] + " ");
          System.out.println();

   }   
}
