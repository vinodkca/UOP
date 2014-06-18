package Week2;

/**
 *
 * @author vinodk
 */
import java.util.Scanner;  // Needed for the Scanner class
import java.text.DecimalFormat;

/**
 * This program has a problem reading input.
 */
public class InputProblem {

    String name;   // To hold the user's name
        int age;       // To hold the user's age
        double income; // To hold the user's income

        
    public static void main(String[] args) {
        String name = "Test";   // To hold the user's name
        int age;       // To hold the user's age
        double income; // To hold the user's income

        // Create a Scanner object to read input.
        Scanner keyboard = new Scanner(System.in);

        // Get the user's age.
        System.out.print("What is your age? ");
        age = keyboard.nextInt();

        // Get the user's income
        System.out.print("What is your annual income? ");
        income = keyboard.nextDouble();

        // Get the user's name.
        System.out.print("What is your name? ");
        name = keyboard.nextLine();

        // Display the information back to the user.
        System.out.println("Hello " + name + ". Your age is "
                + age + " and your income is $"
                + income);

        System.out.println("How to Round");
        System.out.println("**Using String:");
        System.out.println(String.format("%.2f", 1.2399)); // returns "1.24"
        System.out.println(String.format("%.3f", 1.2399)); // returns "1.240"
        System.out.println(String.format("%.2f", 1.2)); // returns "1.20"

        System.out.println("**Using PrintStream):");
        System.out.printf("%.2f", 1.2399); // same syntax as String.format()
        System.out.println();
        System.out.printf("If you don’t want trailing zeroes:");
        System.out.println();

        System.out.println("**Using Decimal Format");
        DecimalFormat formatter1 = new DecimalFormat("#0.00");
        DecimalFormat formatter2 = new DecimalFormat("#0.##");
        //double d = 564.279;
        double d = 564;
        System.out.println(formatter1.format(d));
        System.out.println(formatter2.format(d));
        //new DecimalFormat("0.00").format(1.2)// returns "1.20"
        //new DecimalFormat("0.##").format(1.2)// returns "1.2"
    }
}
