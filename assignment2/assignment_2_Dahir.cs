// Name: Zach Dahir
// Date: 9-07-21
// Assignment:  Assignment 2 - Time-distance calculation.

using System;

public class TimeDistance
{
    //Declare your private class variables for distance, speed, and time here -
    //remember to assign it the default values given in the assignment.
    //Also remember that these are "visible" to all methods in the class, 
    //but not to the actual object unless we "get" or "set" them.
    private double distance;
    private double speed;
    private double time;
    

    //Constructor that takes no arguments
    public TimeDistance()
    {
        
    } 
    
    //Constructor shell that should take two arguments and assign
    //those values to whatever your variables for distance and time are
    public TimeDistance(double d, double s)
    {
        distance = d;
        speed = s;
    }
    
    
    //Now we declare our "getter" and "setter" for our class variables.
    //Remember, you DO NOT need a "setter" for the amount of time it will
    //take to go your distance, so you should only have five methods here.  
    //Also remember that "getters" and "setters" need to be declared as public
    //You will have to fill in what goes after each "public" and also fill in
    //what code goes inside of the curly braces ("{}")
    public double getDistance()
    {
        return distance;
    }
    
    public void setDistance(double d)
    {
        distance = d;
    }
    
    public double getSpeed()
    {
        return speed;
    }
    
    public void setSpeed(double s)
    {
        speed = s;
    }
    
    public double getTime()
    {
        return time;
    }
    
    
    //Calculate the amount of time it will take to travel
    //the given distance at the given speed
    public void computeTime()
    {
        time = distance / speed;
    }

    
} // end class TimeDistance

public class timeDistanceTest
{
	public static void Main( string[] args )
	{
	    //Instantiate a TimeDistance object using the empty constructor
	    TimeDistance test1 = new TimeDistance();

	    //Use the setters to set the values as described in the assignment
	    test1.setDistance(243);
        test1.setSpeed(24);

	    //Use the calculate method to determine the amount of time it will take to
	    //go that distance based on that speed
	    test1.computeTime();

	    //Display your output as shown in the example (you will use the getters for this)
	    Console.WriteLine("To go a distance of " + test1.getDistance() + " at a speed of " + test1.getSpeed() + " will take a time of " + test1.getTime());

	    //Instantiate a new (i.e. use a new name) TimeDistance object by passing the two 
	    //variables to the constructor as directed in the assignment
	    TimeDistance test2 = new TimeDistance(257, 75.3);
        
	    //Use the calculate method to determine the amount of time it will take to
	    //go that distance based on that speed
	   	test2.computeTime();
		
		Console.WriteLine("To go a distance of " + test2.getDistance() + " at a speed of " + test2.getSpeed() + " will take a time of " + test2.getTime());
		
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
	} // end Main
} // end class timeDistanceTest