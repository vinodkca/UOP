package Week5_Sp;

import java.text.DecimalFormat;
import java.util.Scanner;
import java.util.*;

public class Functions 
{
    // GLOBAL VARIABLES used throughout the program
    static public double commissionRate = 0.05; // Stores the commission percentage
    static public double targetSales = 120000 * 0.8; // Stores the target sales number
    static DecimalFormat z = new DecimalFormat("##.00"); // Ensures that all dollar variables have two decimal points behind the value
    Scanner input = new Scanner(System.in); // Used to get input from user
    
    CommissionCalc c = new CommissionCalc(); // Used to call upon Global Variables from the CommissionCalc class
    
    // Function prints out the menu choices available for the user,
    // retrieves input from user as to what they would like to do, 
    // and calls upon the function to handle the need
    public void printChoices() 
    {
        int choice;
        System.out.println("\nChoices:");
        System.out.println("<1> Enter Emloyees\n<2> Print Employee Information\n<3> Print Potential Earnings\n<4> Compare Employees\n<5> Exit");
        System.out.print("\nYour Choice: ");
        choice = input.nextInt();
        if(c.employeeName[0] == null && (choice > 1 && choice < 5))
        {
            choice = 10;
            System.out.println("\nNo Employees Have Been Added into the Program...");
            System.out.print("Would you like to enter employees? (1 - YES / 2 - NO): ");
            choice = input.nextInt();
            while(choice < 1 || choice > 2)
            {
                System.out.println("Invalid Entry...Try again...");
                System.out.print("Would you like to enter employees? (1 - YES / 2 - NO): ");
            }
            if(choice == 2)
                choice = 10;
            
        }
        switch(choice)
        {
            case 1:
                getEmployeeData();
                break;
            case 2:
                printEmployeeData();
                break;
            case 3:
                printPotentialEarnings();
                break;
            case 4:
                compareEmployees();
                break;
            case 5:
                c.done = true;
                System.out.println("\nThank you for using The Simple Commission Calculator...Goodbye!\n");
                break;
            default:
                System.out.println("\nInvalid Entry...Try Again...");
                break;
        }
        
    }
    // Function asks for NAME and ANNUAL SALES of two employees,
    // and calls upon the calcCommission() function to calculate whether
    // employee recieves commission or not
    public void getEmployeeData()
    {
        for(int i = 0; i < 2; i++)
        {
            input.nextLine();
            // User Inputs Employee Name
            System.out.print("\nPlease enter name for Employee " + (i+1) + ": ");
            c.employeeName[i] = input.nextLine();
            // User Inputs Employee Annual Sales
            System.out.print("Please enter annual sales for " + c.employeeName[i] + ": ");
            c.annualSales[i] = input.nextDouble();
            // Calculate Commission for Employees
            calcCommission(i);
        }
    }
    // Function calculates whether or not employee recieves 
    // commission based on the ANNUAL SALES of the employee
    public void calcCommission(int num)
    {
        if(c.annualSales[num] >= targetSales)
            {
                c.compensation[num] = c.fixedSalary[num] + (c.annualSales[num] * commissionRate);
                //The following will provide a result with compensation if
                //eligable for commission
                System.out.println("Congratulations " + c.employeeName[num] + ", you qualified for a 5% commission bonus! Your total compensation is $" + z.format(c.compensation[num]) + "\n");
            }
            else
            {
                c.compensation[num] = c.fixedSalary[num];
                //The following will provide a result with compensation if not
                //eligable for commission
                System.out.println("Sorry " + c.employeeName[num] + ", you did not qualify for a 5% commission bonus. Your total compensation is $" + z.format(c.compensation[num]) + "\n");
            }
    }
    // Simple function that prints employee data such as
    // NAME, ANNUAL SALES, and the employees TOTAL COMPENSATION
    public void printEmployeeData()
    {
        System.out.println("\nName\t\tTotal Sales\t\tTotal Compensation"); 
        System.out.println("----------------------------------------------------------"); 
        for(int i = 0; i < 2; i++)
        {
            System.out.println(c.employeeName[i] + "\t\t  " + z.format(c.annualSales[i]) + "\t\t   " + z.format(c.compensation[i]));
        }
    }
    // Function prints out the potential earnings an employee could have
    // recieved during the year based on the employee's actual sales
    public void printPotentialEarnings()
    {
        System.out.println("\n*** POTENTIAL SALES ***");
        for(int i = 0; i < 2; i++)
        {
            double tempCommission = 0.0;
            double tempSalary = c.fixedSalary[i];
            double tempAnnual = c.annualSales[i];
            double tempTarget = c.annualSales[i] + (c.annualSales[i] * 0.5);
            System.out.println("\nEMPLOYEE: " + c.employeeName[i]);
            System.out.println("Potential Sales\t\tPotential Compensation"); 
            System.out.println("----------------------------------------------");
            while(tempAnnual <= tempTarget)
            {
                if(tempAnnual > (120000 * 0.8))
                    tempCommission = tempAnnual * 0.05;
                System.out.print(z.format(tempAnnual) + "\t\t");
                if(tempAnnual < (120000*0.8))
                    System.out.print("\t");
                System.out.println(z.format(tempSalary+tempCommission));
                tempAnnual = tempAnnual + 5000;
            }
        }
    }
    // Function compares two employees sales and earnings and informs the
    // lesser performing employee how muich better they have to do in 
    // order to earn as much money as the better performing employee
    public void compareEmployees()
    {
        System.out.println("\n*** EMPLOYEE COMPARISON ***");
        printEmployeeData();
        if(c.annualSales[0] > c.annualSales[1]) // If employee 1 has higher sales
        {
            System.out.println(c.employeeName[1] + " has to sell $" + z.format((c.annualSales[0] - c.annualSales[1])) + " more to match " + c.employeeName[0] + "'s Sales");
        }
        else // If employee 2 has higher sales
        {
            System.out.println(c.employeeName[0] + " has to sell $" + z.format((c.annualSales[1] - c.annualSales[0])) + " more to match " + c.employeeName[1] + "'s Sales");
        }
    }   
}
