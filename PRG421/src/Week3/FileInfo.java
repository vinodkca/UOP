package Week3;

import java.io.*;
import java.util.ArrayList;

public class FileInfo {

//    public boolean WriteBinaryFile(int[] arrVal, String filename) {
//        FileOutputStream fstream = null;
//        DataOutputStream outputFile = null;
//        try {
//            // Open a binary file for output.
//            fstream = new FileOutputStream(filename);
//            outputFile = new DataOutputStream(fstream);
//
//            // Write the array elements to the binary file.
//            for (int i = 0; i < arrVal.length; i++) {
//                outputFile.writeInt(arrVal[i]);
//            }
//        } 
//        catch (IOException ex) {
//             return false;
//        } 
//        finally {
//            
//            try
//            {
//                // Close the file.
//                outputFile.close();
//            }
//            catch(Exception ex)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
    
     public void WriteBinaryFile(int[] arrVal, String filename) throws IOException  
     {       
            // Open a binary file for output.
            FileOutputStream fstream = new FileOutputStream(filename);
            DataOutputStream outputFile = new DataOutputStream(fstream);

            // Write the array elements to the binary file.
            for (int i = 0; i < arrVal.length; i++) {
                outputFile.writeInt(arrVal[i]);
            }
                // Close the file.
             outputFile.close();
       
    }
     
    public ArrayList<Integer> ReadBinaryFile(String filename) throws IOException {
        ArrayList<Integer> alValues = new ArrayList<Integer>();
        int number; // To hold a number
        boolean endOfFile = false; // End of file flag
        // Open Numbers.dat as a binary file.
        FileInputStream fstream = new FileInputStream(filename);
        DataInputStream inputFile = new DataInputStream(fstream);

        // Read data from the file.
        while (!endOfFile) {
            try {
                number = inputFile.readInt();
                alValues.add(number);
            } catch (EOFException e) {
                endOfFile = true;
            }
        }
        // Close the file.
        inputFile.close();
        return alValues;
    }
    
     public void WriteUTF(String strVal, String filename) throws IOException  
     {       
            // Open a binary file for output.
            FileOutputStream fstream = new FileOutputStream(filename);
            DataOutputStream outputFile = new DataOutputStream(fstream);                     
            outputFile.writeUTF(strVal);
            outputFile.close();       
    }
     
      public String ReadUTF(String filename) throws IOException {
        FileInputStream fstream = new FileInputStream(filename);
        DataInputStream inputFile = new DataInputStream(fstream);

        String name = inputFile.readUTF();
        // Close the file.
        inputFile.close();
        return name;
    }
      
     public void WriteObject(Object obj, String filename) throws IOException  
     {       
            // Open a binary file for output.
            FileOutputStream fstream = new FileOutputStream(filename);
            ObjectOutputStream outputFile = new ObjectOutputStream(fstream);

            // Write the array elements to the binary file.
            outputFile.writeObject(obj);
            // Close the file.
             outputFile.close();
       
    }
     
       public Object ReadObject(String filename) throws Exception {
        FileInputStream fstream = new FileInputStream(filename);
        ObjectInputStream inputFile = new ObjectInputStream(fstream);

        Object obj = inputFile.readObject();
        // Close the file.
        inputFile.close();
        return obj;
    }
      
}
