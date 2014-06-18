
package Week5;

class Company
{
    //Right click on the class Refractor->Encapsulate Fields
    int CompanyID;
    private String CompanyName;    

    public int getCompanyID() {
        return CompanyID;
    }

    public void setCompanyID(int CompanyID) {
        this.CompanyID = CompanyID;
    }

    public String getCompanyName() {
        return CompanyName;
    }

    public void setCompanyName(String CompanyName) {
        this.CompanyName = CompanyName;
    }    
}



class Employee extends Company
{
    private int EmployeeID;
    private String EmployeeName;    

    public int getEmployeeID() {
        return EmployeeID;
    }
   
    public void setEmployeeID(int EmployeeID) {
        this.EmployeeID = EmployeeID;
    }

    public String getEmployeeName() {
        return EmployeeName;
    }
  
    public void setEmployeeName(String EmployeeName) {
        this.EmployeeName = EmployeeName;
    }
}


public class ClassHierarchy extends Employee
{
    protected int bb=20;
    //Ctrl space bar
    public ClassHierarchy() {
        this.setCompanyID(1234);
        this.setCompanyName("CompanyA");        
        this.setEmployeeID(1);
        this.setEmployeeName("Employee1");  
    }
    
      public void setValues() {
        this.setCompanyID(1234);
        this.setCompanyName("CompanyA");        
        this.setEmployeeID(1);
        this.setEmployeeName("Employee1");  
    }
    //psvm
    public static void main(String[] args) {        
        
        //Using this ??
        ClassHierarchy aa = new ClassHierarchy();
        //Non static cannot be referenced in static and trick is ur use instance
        //setValues();
        //trick is ur use instance or marke function as static
        aa.setValues();
        
        System.out.println("Company Name " + aa.getCompanyID());
        System.out.println("Company Name " + aa.getCompanyName());
        System.out.println("Employee ID " + aa.getEmployeeID());
        System.out.println("Employee Name " + aa.getEmployeeName());
        
    }
    
}
