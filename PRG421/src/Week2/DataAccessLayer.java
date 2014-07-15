package Week2;

import java.util.ArrayList;

public class DataAccessLayer {
    
    public ArrayList<Employee> getEmployees()
    {
        ArrayList<Employee> alEmployee = new ArrayList<Employee>();
        
        for (int i = 0; i < 10; i++) {
            Employee emp = new Employee();
            emp.ID = i;
            emp.FirstName = "First " + Integer.toString(i);
            emp.LastName = "Last " + Integer.toString(i);
            
            alEmployee.add(emp);            
        }
        return alEmployee;       
        
    }
    
    
}
