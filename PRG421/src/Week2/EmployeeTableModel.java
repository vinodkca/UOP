
package Week2;

import java.util.ArrayList;
import javax.swing.table.AbstractTableModel;


public class EmployeeTableModel extends AbstractTableModel
{    
   private String[] columnNames = {"ID","First Name", "Last Name"};
   
   private ArrayList<Employee> data = new DataAccessLayer().getEmployees();
   
   @Override
    public int getRowCount() {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
       return data.size();
    }

    @Override
    public int getColumnCount() {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        return columnNames.length;
    }

    @Override
    public Object getValueAt(int iRowIndex, int iColumnIndex) {
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        Employee emp = data.get(iRowIndex);
        switch(iColumnIndex)
        {
            case 0:
                return emp.ID;              
            case 1:
                return emp.FirstName;               
             case 2:
                return emp.LastName;
             default:
                 new UnsupportedOperationException("Not supported yet.");                
        }    
        return null;
    }
      
    //Not Sure if needed add apart from Interface
    @Override
     public String getColumnName(int iCol)
     {
         return columnNames[iCol];
      }    
}
