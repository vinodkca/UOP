package Week3;

import java.applet.Applet;
import java.awt.Graphics;

public class FirstApplet extends Applet {

    public void paint(Graphics g) {
        g.drawString("Welcome in Java Applet.", 40, 20);
    }
}

//
//<HTML>
// <HEAD>
// </HEAD>
// <BODY>
// <APPLET ALIGN="CENTER" CODE="FirstApplet.class" WIDTH="800" HEIGHT="500"></APPLET>
// </BODY>
// </HTML>