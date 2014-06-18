/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week2;

/**
 *
 * @author vinodk
 */
public class LoopClass {

    /**
     * Returns an Image object that can then be painted on the screen
     * @param args Used for passing parameters
     * Tools Other ->windows->javadoc
     */
    public static void main(String[] args) {
        int number = 1;

        while (number <= 5) {
            System.out.println("Hello" + number);
            number++;
        }

        System.out.println("That's all!");

        // Loop control variable 
        //int number=0;    
        //int maxValue = 5;   

        for (int i = 0; i < 10; i++) {
            System.out.print("\nvalue of i : " + i);
        }            
    }
}
