/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week4;
/*
 *Main class
 *Main.java
 */

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Main extends JApplet implements ActionListener{
	Ball ball;
	Timer timer;
	final int DELAY = 50;
	
	public void init(){
		//set background color
		this.setBackground(Color.black);
		//this.setBackground(new Color(100,0,100));
		//use default constructor for test
		ball = new Ball();
		//constructor Timer(int millidelay, ActionListener l)
		timer = new Timer(DELAY, this);
		repaint();
	}
	
	public void start(){
		timer.start();
	}
	
	public void stop(){
		timer.stop();
	}
	
	public void destroy(){
		//System.exit(0);
	}
	
	public void paint(Graphics g){
		super.paint(g);
		ball.moveBall(g);
	}
	
	public void actionPerformed(ActionEvent e){
		if(e.getSource() == timer){
			//call paint method
			repaint();
		}
	}
}