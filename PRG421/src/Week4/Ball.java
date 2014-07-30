/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week4;

/*
 *Ball Class
 *Ball.java
 */

import java.awt.*;

public class Ball{
	private int xPos;
	private int yPos;
	//speed at which balls coord's are incremented/decremented
	private int xIncr = 3;
	private int yIncr = 3;
	private Color col;
	final int size = 25;
	//size of Applet: 300 x 400
	static final int WIDTH = 300;
	static final int HEIGHT = 400;

	public Ball(int x, int y, Color color){
		xPos = x;
		yPos = y;
		col = color;
	}
	
	public Ball(){
		//starting position
		this(150,150,Color.blue);
	}
	
	public int getXPos(){
		return xPos;
	}
	
	public int getYPos(){
		return yPos;
	}
	
	public void checkBounce(){
		System.out.println("checkBounce");
		if(xPos < 0 || xPos > WIDTH - size){
			//ball hit left or right of applet
			this.reverseX();
		}
		
		if(yPos < 0 || yPos > HEIGHT - size){
			//ball hit top or bottom of applet
			this.reverseY();
		}
	}
	
	public void reverseX(){
		//debugging print statement
		System.out.println("reverseX");
		xIncr = (-1)* xIncr;
	}
	
	public void reverseY(){
		//debugging print statement
		System.out.println("reverseY");
		yIncr = (-1)* yIncr;
	}
	
	public void moveBall(Graphics g){
		checkBounce();
		g.setColor(col);
		g.fillOval(xPos, yPos, size, size);
		xPos += xIncr;
		yPos += yIncr;
		System.out.println("(" + xPos + " , " + yPos + ")");
	}
}


