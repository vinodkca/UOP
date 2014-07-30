/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week4;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

/**
 * This class represents the central panel of the program, where the actual
 * drawing is done. It contains an inner class, which listens for MouseEvents
 * and draws using the panel's Graphics object, depending on which shape and
 * colour buttons are selected.
 */
public class DrawingPanel extends JPanel {
    /** The default background colour for the panel */
    private final static Color BACKGROUND = Color.WHITE;

    /** An enum declaration for the different drawing shapes */
    private enum DrawingShape { DRAW, LINE, RECTANGLE, ELLIPSE; }

    /** Keeps track of the current shape */
    private DrawingShape shape;
    /** Keeps track of the current colour */
    private Color colour;
    /** When drawing a shape, keeps track of the starting point (where the
     * mouse button was initially pressed) */
    private int startingX, startingY;
    /** When drawing a shape, keeps track of the current point (where the
     * mouse pointer is currently) */
    private int currentX, currentY;

    /**
     * This constructor simply sets the background color, adds the listener
     * and sets the default shape and colour. Note that two listeners are
     * required: MouseListener to listen for pressing, clicking and releasing;
     * and MouseMotionListener for dragging. We have used the same listener
     * object (DrawingPanelListener) for both.
     */
    public DrawingPanel() {
        setBackground(BACKGROUND);
        DrawingPanelListener listener = new DrawingPanelListener();
        addMouseListener(listener);
        addMouseMotionListener(listener);
        shape = DrawingShape.DRAW;
        colour = Color.BLACK;
    }

    /**
     * Set the current shape for the drawing panel. This gets called when a
     * shape button is clicked.
     * @param shape the shape to set to in String form
     */
    public void setShape(String shape) {
        if (shape == "Draw")
            this.shape = DrawingShape.DRAW;
        else if (shape == "Line")
            this.shape = DrawingShape.LINE;
        else if (shape == "Rectangle")
            this.shape = DrawingShape.RECTANGLE;
        else if (shape == "Ellipse")
            this.shape = DrawingShape.ELLIPSE;
    }

    /**
     * Set the current colour for the drawing panel. This gets called when a
     * colour button is clicked.
     * @param colour the colour to set to in String form
     */
    public void setColour(String colour) {
        if (colour == "Black")
            this.colour = Color.BLACK;
        else if (colour == "White")
            this.colour = Color.WHITE;
        else if (colour == "Red")
            this.colour = Color.RED;
        else if (colour == "Green")
            this.colour = Color.GREEN;
        else if (colour == "Blue")
            this.colour = Color.BLUE;
        else if (colour == "Cyan")
            this.colour = Color.CYAN;
        else if (colour == "Magenta")
            this.colour = Color.MAGENTA;
        else if (colour == "Yellow")
            this.colour = Color.YELLOW;
        else if (colour == "Orange")
            this.colour = Color.ORANGE;
        else if (colour == "Pink")
            this.colour = Color.PINK;
    }

    // Other setter methods
    public void setStartingX(int x) { startingX = x; }
    public void setStartingY(int y) { startingY = y; }
    public void setCurrentX(int x) { currentX = x; }
    public void setCurrentY(int y) { currentY = y; }

    // Getter methods
    public DrawingShape getShape() { return shape; }
    public Color getColour() { return colour; }
    public int getStartingX() { return startingX; }
    public int getStartingY() { return startingY; }
    public int getCurrentX() { return currentX; }
    public int getCurrentY() { return currentY; }

    /**
     * This is the listener for the DrawingPanel. It extends MouseAdapter,
     * which is a convenient class for handling mouse events. It implements
     * both the MouseListener and MouseMotionListener interfaces, meaning it
     * can handle both press/click/release type events as well as move/drag
     * events. The other nice thing is that we only need to override the
     * methods we are interested in, and can ignore the rest.
     */
    private class DrawingPanelListener extends MouseAdapter
    {
        /**
         * When the mouse is pressed, all that needs to be done is to record
         * the starting position, and set the current position to the same
         * point. The actual drawing is done when the mouse is dragged or
         * released.
         */
        @Override
        public void mousePressed(MouseEvent e) {
            DrawingPanel panel = (DrawingPanel) e.getSource();
            panel.setStartingX(e.getX());
            panel.setStartingY(e.getY());
            panel.setCurrentX(e.getX());
            panel.setCurrentY(e.getY());
        }

        /**
         * When the mouse is dragged, some drawing must happen. If the shape
         * is set to DRAW, then we just directly draw in the direction of the
         * drag. Otherwise, we draw a skeleton of the current shape, which
         * will be made permanent when the mouse is released. In drawing the
         * skeleton shape, we must remove the old shape first.
         */
        @Override
        public void mouseDragged(MouseEvent e) {
            DrawingPanel panel = (DrawingPanel) e.getSource();
            Graphics g = panel.getGraphics();
            if (panel.getShape() == DrawingShape.DRAW) {
                // When drawing, we always use paint mode because it will not
                // need to be removed
                g.setPaintMode();  
                g.setColor(panel.getColour());
                // We draw a line to prevent gaps in the paint when dragging
                // quickly
                g.drawLine(panel.getCurrentX(), panel.getCurrentY(), e.getX(),
                        e.getY());
                // Update to the current mouse position
                panel.setCurrentX(e.getX());
                panel.setCurrentY(e.getY());
            }
            else {
                // Remove old shape
                drawShape(panel, panel.getStartingX(), panel.getStartingY(),
                        panel.getCurrentX(), panel.getCurrentY(), false, false);
                // Update to the current mouse position
                panel.setCurrentX(e.getX());
                panel.setCurrentY(e.getY());
                // Draw new shape
                drawShape(panel, panel.getStartingX(), panel.getStartingY(),
                        panel.getCurrentX(), panel.getCurrentY(), false, false);
            }
        }

        /**
         * When the mouse is released, we permanently draw the shape that is
         * currently being formed. If the current shape is DRAW, nothing will
         * happen as the drawing has already been done. Otherwise, the
         * existing skeleton shape must be removed before the shape is
         * permanently painted on the panel. If it is the right mouse button
         * that is released, then a filled shape will be drawn; otherwise a
         * hollow shape will be drawn.
         */
        @Override
        public void mouseReleased(MouseEvent e) {
            DrawingPanel panel = (DrawingPanel) e.getSource();
            Graphics g = panel.getGraphics();
            // Remove old skeleton shape (in XOR mode)
            drawShape(panel, panel.getStartingX(), panel.getStartingY(),
                    panel.getCurrentX(), panel.getCurrentY(), false, false);
            // Update to the current mouse position
            panel.setCurrentX(e.getX());
            panel.setCurrentY(e.getY());
            // Draw the final shape (in paint mode). The fill parameter will
            // be true if the right mouse button is used
            drawShape(panel, panel.getStartingX(), panel.getStartingY(),
                    panel.getCurrentX(), panel.getCurrentY(),
                    e.getButton() == MouseEvent.BUTTON3, true);
        }

        /**
         * This method draws a shape on the Graphics object of the supplied
         * panel with the given points, fill and paint properties. The shape
         * to be drawn and the colour are determined by the current shape and
         * colour attributes in the supplied panel.
         * @param panel the panel to draw on
         * @param x1 the x-coordinate of the first point
         * @param y1 the y-coordinate of the first point
         * @param x2 the x-coordinate of the second point
         * @param y2 the y-coordinate of the second point
         * @param fill true if the shape is to be drawn filled; it will be
         * hollow otherwise
         * @param paint true if the shape is to be drawn in paint mode; it
         * will be drawn in XOR mode otherwise
         */
        private void drawShape(DrawingPanel panel, int x1, int y1, int x2,
                int y2, boolean fill, boolean paint) {
            // All painting is done on the panel's Graphics object
            Graphics g = panel.getGraphics();
            g.setColor(panel.getColour());
            if (paint)
                // Shape is to be drawn permanently
                g.setPaintMode();  
            else
                // Shape can be erased by drawing it twice
                g.setXORMode(panel.BACKGROUND);

            // For drawing rectangles and ellipses, it is necessary to use the
            // minimum x and y values because those shapes are drawn from the
            // upper left corner, and the width and height must not be
            // negative.
            int minX = Math.min(x1, x2);
            int minY = Math.min(y1, y2);
            int width = Math.abs(x2 - x1);
            int height = Math.abs(y2 - y1);

            // Draw the shape. It will be a line, rectangle or circle
            // depending on the panel's current shape
            switch (panel.getShape()) {
                case LINE:
                    g.drawLine(x1, y1, x2, y2);
                    break;
                case RECTANGLE:
                    if (fill)
                        g.fillRect(minX, minY, width, height);
                    else
                        g.drawRect(minX, minY, width, height);
                    break;
                case ELLIPSE:
                    if (fill)
                        g.fillOval(minX, minY, width, height);
                    else
                        g.drawOval(minX, minY, width, height);
                    break;
            }
        }
    }
}

