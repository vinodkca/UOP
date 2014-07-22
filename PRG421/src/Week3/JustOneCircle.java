/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package Week3;

import javax.swing.JApplet;
import java.awt.*;

public class JustOneCircle extends JApplet {

    /**
     * Initialization method that will be called after the applet is loaded into
     * the browser.
     */
    public void init() {
        // TODO start asynchronous download of heavy resources
    }

   final int radius = 25;

  public void paint ( Graphics gr )
  { 
    gr.setColor( Color.white );
    gr.fillRect( 0, 0, 150, 150 );
    gr.setColor( Color.black );

    gr.drawOval( (150/2 - radius), (150/2 - radius), radius*2, radius*2 );
   }
}

