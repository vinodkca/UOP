package Week4;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class EmpSalaryList {
       public static void main(String[] args) {
           
        Scanner sc = new Scanner(System.in);        
        System.out.println("Please enter your number of employees:");
        int iLen = sc.nextInt();
        
        ArrayList<Employee> employeeList= new ArrayList<Employee>();
        //Employee[] array = new Employee[iLen];
        double[] salary = new double[iLen];
        Employee[] sortedEmployee = new Employee[iLen];
        
        for(int i = 0; i < iLen; i++) {
            System.out.println("Please enter your employee name");
            String e = sc.next();
            System.out.println("Please enter your salary:");
            double s = sc.nextDouble();
            salary[i] = s;
            employeeList.add(new Employee(e, s));
        }
        
        Arrays.sort(salary);
        
        //Sorted Array
         for(int i = 0; i < salary.length; i++) {
             System.out.println("Sorted Salary " + salary[i]);
             for (int j = 0; j < employeeList.size(); j++) {
                 if(employeeList.get(j).getSalary() == salary[i] )
                 {
                     sortedEmployee[i] = employeeList.get(j);
                 }
             }             
         }
         
         //Print Employees
          for(int i = 0; i < sortedEmployee.length; i++) {
              System.out.println("Sorted employee number " + sortedEmployee[i].getEmpName());
              System.out.println("Sorted employee salary " + sortedEmployee[i].getSalary());
          }
       }
}
