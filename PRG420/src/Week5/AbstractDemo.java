/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Week5;

import java.util.Date;

abstract class  Server
{
    protected final String servername;
   
    //Can abstract class have constrauctor??
    public Server(String name){
        this.servername = name;
    }
   
    //Can abstract workd if class is not sbatract??
    public abstract boolean start();
    
    //Can abstract have no abstract function??
    public boolean stop()
    {
        return true;
    }
}

//Can i do multipel class
/*abstract class  ServerAA
{

}
class Tomcat extends Server,ServerAA
public interface NameOfInterface
{
   //Any number of final, static fields
   //Any number of abstract method declarations\
}
* Only one public class in a file
*/
interface StartServerInter
{
    //public static String startTime = (new Date()).toString();//U cannot see in derived class
    public final String startTime = (new Date()).toString();
    public abstract boolean start();
}

interface StopServerInter
{
     //u can declare but cannot be used outside the class
   // public static String stopTime = (new Date()).toString();
    public abstract boolean stop();
}


class Tomcat extends Server implements StartServerInter, StopServerInter
{
   
    public Tomcat(String name){
        super(name);
    }
 
    //You need attribute to override abstrcat method
    //@Override ?? optional
    public boolean start() {
        //accessing the basse class variable 
       System.out.println( this.servername + " started successfully ");
      
     //u can declare but cannot be used outside the class using this
       System.out.println( StartServerInter.startTime + " started successfully ");
       return true;
    }
}

public class AbstractDemo {
    public static void main(String[] args) {
       Server server = new Tomcat("Apache Tomcat");
       server.start();
       server.stop();
       //System.out.println( StopServerInter.startTime + " started successfully ");
       
    }
}
