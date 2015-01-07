package Week4;
public class Employee {
    private String empName;
    private double empSal;

    public Employee(String e, double s){
        empName = e;
        empSal = s;
    }

    public String getEmpName(){
        return empName;
    }
    public double getSalary(){
        return empSal;

    } 
}
