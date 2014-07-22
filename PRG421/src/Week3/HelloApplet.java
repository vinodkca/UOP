/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week3;

import java.applet.Applet;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;

/**
 *
 * @author vinodk
 */
public class HelloApplet extends Applet {

    /**
     * Initialization method that will be called after the applet is loaded into
     * the browser.
     */
    public void init() {
        // TODO start asynchronous download of heavy resources
    }
    // TODO overwrite start(), stop() and destroy() methods
     public void paint(Graphics g) {
      setBackground(Color.CYAN);   // set background color
      g.setColor(Color.BLACK);     // set foreground text color
      g.setFont(new Font("Times New Roman", Font.BOLD, 30)); // set font face, bold and size
      g.drawString("Hello, world", 20, 80);  // draw string with baseline at (20, 80)
   }

}
