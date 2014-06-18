package Week4;
public class StringDemo {
    //psvm 

    public static void main(String[] args) {
        ModifiedString(); 
        PeopleSearch();        
    }


    private static void ModifiedString() {
        //PeopleSearch();
        
        String fullName,firstName = "Timothy ",lastName = "Taynes";
        //fullName = firstName + lastName;
        fullName = firstName.concat(lastName);
        System.out.println(fullName);
        String str2 = fullName.replace('T', 'D');
        System.out.println(fullName);
        System.out.println(str2);
        str2 = str2.substring(2,6); //moth ??
        System.out.println(str2);
    }
    
        private static void PeopleSearch() {
        String search = "Smith";  // To hold a lookup string
        // Create an array of names.
        String[] people = {"Smith, Kathryn", "Smith, Chris", "Williams, Jean"};

        for (String person : people) {
            if (person.startsWith(search)) {
                //sout
                System.out.println("Full Name : " + person);
                
                // Get the tokens, using a space delimiter.
                String[] tokens = person.split(",");

                // Display the tokens.
                for (String s : tokens)
                   System.out.println(s.trim());

            }
        }
    }

}
