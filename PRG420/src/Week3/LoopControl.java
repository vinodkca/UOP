/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week3;

import java.util.Scanner;

/**
 *
 * @author vinodk
 */
public class LoopControl {

    public static void main(String args[]) {
        ifelseLoop();
        prepostMethod();
        // System.exit(0); //A non-zero exit status code, usually indicates abnormal termination 0 means everything wnet fine
        doWhileLoop();
        forLoop();
        enhancedForLoop();
        breakLoop();
        noBreakSwitch();




    }

    private static void doWhileLoop() {
        int x = 10;
        do {
            System.out.print("value of x : " + x);
            x++;
            System.out.print("\n");
        } while (x < 20);
    }

    private static void forLoop() {
        for (int x = 10; x < 20; x = x + 1) {
            System.out.print("value of x : " + x);
            System.out.print("\n");
        }
    }

    private static void enhancedForLoop() {
        int[] numbers = {10, 20, 30, 40, 50};

        for (int x : numbers) {
            System.out.print(x);
            System.out.print(",");
        }
        System.out.print("\n");
        String[] names = {"James", "Larry", "Tom", "Lacy"};
        for (String name : names) {
            System.out.print(name);
            System.out.print(",");
        }
    }

    private static void breakLoop() {
        int[] numbers = {10, 20, 30, 40, 50};

        for (int x : numbers) {
            if (x == 30) {
                break;
            }
            System.out.print(x);
            System.out.print("\n");
        }
    }

    private static void prepostMethod() {
        int number = 4;
        int x = number++;
        int y = ++number;
        System.out.println("Now, number is " + x);
        System.out.println("Now, number is " + y);
    }

    private static void ifelseLoop() {
        int books = 5, coupons = 0;

        if (books < 1) {
            coupons = 0;
        } else if (books < 3) {
            coupons = 1;
        } else if (books < 5) {
            coupons = 2;
        } else {
            coupons = 3;
        }

        System.out.println("Number of coupons: "
                + coupons);
        

    }

    private static void noBreakSwitch() {
        String input; // To hold keyboard input
      char choice;  // To store the user's choice

      // Create a Scanner object to read input.
      Scanner keyboard = new Scanner(System.in);

      // Ask the user to enter A, B, or C.
      System.out.print("Enter A, B, or C: ");
      input = keyboard.nextLine();
      choice = input.charAt(0);  // Get the first char
      
      // Determine which character the user entered.
      switch (choice)
      {
         case 'A':
            System.out.println("You entered A.");
         case 'B':
            System.out.println("You entered B.");
         case 'C':
            System.out.println("You entered C.");
         default:
            System.out.println("That's not A, B, or C!");
      }
    }
}
