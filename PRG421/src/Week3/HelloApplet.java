/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week3;

import java.applet.Applet;
import java.awt.Color;
import java.awt.Font;
import java.awt.GradientPaint;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.Ellipse2D;
import java.awt.geom.GeneralPath;
import java.awt.geom.Line2D;
import java.util.Date;

/**
 *
 * @author vinodk JApplets don't even have a paintComponent method. you need to
 * paint in a JPanel Again, you need to override the JPanel's paintComponent
 * method And again this JPanel needs to be the contentPane of the JApplet (or
 * else added to the JApplet's contentPane BorderLayout.CENTER).
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
        g.setFont(new Font("Times New Roman", Font.BOLD, 24)); // set font face, bold and size
        g.drawString("Hello, world", 20, 80);  // draw string with baseline at (20, 80)
        Date d = new Date();
        g.drawString(d.toString(), 20, 120);

        DrawCircle(g);
//        DrawArbitaryShape(g);
//        FillEclipse(g);
    }

    public void DrawArbitaryShape(Graphics g) {
        Graphics2D g2 = (Graphics2D) g;

        // draw GeneralPath (polyline)
        int x2Points[] = {0, 100, 0, 100};
        int y2Points[] = {0, 50, 50, 0};
        GeneralPath polyline = new GeneralPath(GeneralPath.WIND_EVEN_ODD, x2Points.length);

        polyline.moveTo(x2Points[0], y2Points[0]);

        for (int index = 1; index < x2Points.length; index++) {
            polyline.lineTo(x2Points[index], y2Points[index]);
        };

        g2.draw(polyline);

    }

    public void FillEclipse(Graphics g) {
        Graphics2D g2 = (Graphics2D) g;
        // fill Ellipse2D.Double
        GradientPaint redtowhite = new GradientPaint(0, 0, Color.RED, 100, 0, Color.WHITE);
        g2.setPaint(redtowhite);
        g2.fill(new Ellipse2D.Double(0, 0, 100, 50));
    }

    public void DrawCircle(Graphics g) {
        final int radius = 25;
        g.setColor(Color.white);
        g.fillRect(0, 0, 150, 150);
        g.setColor(Color.black);

        g.drawOval((150 / 2 - radius), (150 / 2 - radius), radius * 2, radius * 2);

    }
}

//C:\Vinod\Phoenix\Teaching\PRG420\Tutorials\javatutorials\tutorial\2d\geometry\primitives.html
