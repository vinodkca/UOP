package Week5_Sp;

import java.util.ArrayList;
import java.util.Scanner;
public class CommissionCalc 
{	
    // Global Variables used throughout the program
    static double[] fixedSalary = {48000.0, 48000.0}; // Salary Array
    static double[] annualSales = new double[2]; //Annual Sales Array
    static String[] employeeName = new String[2]; // User Name Array
    static double[] commission = new double[2]; // Commission Earned
    static double[] compensation = new double[2]; // Annual Compensation Array
    static boolean done = false; // Controls Whether Program Loops or not
    
    public static void main (String[] args)
    {
        System.out.println("Welcome to The Simple Commission Calculator");
        Functions f = new Functions();
        while(!done) // Used to control the program on whether it exits or continues to loop
        {        
            f.printChoices();
        }
    }
}
    