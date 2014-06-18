/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week3;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;




    
/**
 *
 * @author vinodk
 */
public class FileReadWrite 
{
   public static void main(String[] args) 
   {
       try
       {
        FileRead();
        FileWrite();
       }
       catch(IOException ex)
       {           
            System.out.print("Exception thrown"  + ex.getMessage());
       }
   }

    private static void FileRead() throws FileNotFoundException {
        // Create a Scanner object for keyboard input.
        Scanner keyboard = new Scanner(System.in);

        // Get the filename.
        System.out.print("Enter the filename: ");
        String filename = keyboard.nextLine();

        // Make sure the file exists.
        File file = new File(filename);
        if (!file.exists())
        {
           // Display an error message.
           System.out.println("The file " + filename +
                              " does not exist.");
           
           // Exit the program.
           System.exit(0);
        }
        
        // Open the file.
        Scanner inputFile = new Scanner(file);

        // Read lines from the file until no more are left.
        while (inputFile.hasNext())
        {
           // Read the next name.
           String friendName = inputFile.nextLine();

           // Display the last name read.
           System.out.println(friendName);
        }

        // Close the file.
        inputFile.close();
       
   }

    private static void FileWrite()throws FileNotFoundException {
        String filename;      // File name
         String friendName;    // Friend's name
         int numFriends;       // Number of friends

         // Create a Scanner object for keyboard input.
         Scanner keyboard = new Scanner(System.in);
         
         // Get the number of friends.
         System.out.print("How many friends do you have? ");
         numFriends = keyboard.nextInt();

         // Consume the remaining newline character.
         keyboard.nextLine();
         
         // Get the filename.
         System.out.print("Enter the filename: ");
         filename = keyboard.nextLine();
         
         // Make sure the file does not exist.
         File file = new File(filename);
         if (file.exists())
         {
            // Display an error message.
            System.out.println("The file " + filename +
                               " already exists.");
                               
            // Exit the program.
            System.exit(0);
         }

         // Open the file.
         PrintWriter outputFile = new PrintWriter(file);

         // Get data and write it to the file.
         for (int i = 1; i <= numFriends; i++)
         {
            // Get the name of a friend.
            System.out.print("Enter the name of friend " +
                             "number " + i + ": ");
            friendName = keyboard.nextLine();

            // Write the name to the file.
            outputFile.println(friendName);
         }

         // Close the file.
         outputFile.close();
         System.out.println("Data written to the file.");

    
    }
   
}
