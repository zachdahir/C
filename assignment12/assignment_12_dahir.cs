//Name: Zachary Dahir
//Date: 11-15-21
//Assignment Description: CIS-243 Assignment 12

using System;


namespace assignment12
{

	class MyDrone
	{ 
		// Default values for a drone
		private double numRotors = 4;
		private double velocity = 5;
		private double xPos = 50;
		private double yPos = 50;
		private static String color = "red"; 
		
		// Two Constructors for the MyDrone class
		public MyDrone()
		{ 
		    //This will not be used for this assignment.
		}
		
		
		public MyDrone(double numRotorsParam, double velocityParam, double xPosParam, 
					   double yPosParam, String colorParam)
		{
		    numRotors = numRotorsParam;
			velocity = velocityParam;
			xPos = xPosParam;
			yPos = yPosParam;
			color = colorParam;
		}
		
		// "Getters" for the class variables - fill these in 
		public double getNumRotors()
		{ 
			return numRotors;
		} 	
		 
		public double getVelocity()
		{ 
			return velocity; 
		} 
		
		public double getXPos()
		{ 
			return xPos;
		}
		
		public double getYPos()
		{
			return yPos;
		}
		
		public String getColor()
		{ 
			return color;
		} 

		//Main calculation method
		public double getTimeToHome()
		{ 
			//Do not store your getTimeToHome in your class
			double distance = Math.Sqrt((Math.Pow(xPos - 0, 2) + Math.Pow(yPos - 0, 2)));
			double timeToHome = distance / velocity; 
            return timeToHome;
			
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
			//TODO: Fill in the above class and use it 
			//here according to the directions in the assignment
			MyDrone drone1 = new MyDrone(6, 10, 33, 47, "red");
            Console.WriteLine("Drone 1");
            Console.WriteLine("-------");
			Console.WriteLine("Color: " + drone1.getColor());
			Console.WriteLine("Rotors: " + drone1.getNumRotors());
			Console.WriteLine("Velocity: " + drone1.getVelocity());
			Console.WriteLine("Transit from: " + drone1.getXPos() + "," + drone1.getYPos() + " to home will take " + Math.Round(drone1.getTimeToHome(), 2) + " seconds.");

            Console.WriteLine("");

            MyDrone drone2 = new MyDrone(4, 7, 61, 14, "green");
            Console.WriteLine("Drone 2");
            Console.WriteLine("-------");
			Console.WriteLine("Color: " + drone2.getColor());
			Console.WriteLine("Rotors: " + drone2.getNumRotors());
			Console.WriteLine("Velocity: " + drone2.getVelocity());
			Console.WriteLine("Transit from: " + drone2.getXPos() + "," + drone2.getYPos() + " to home will take " + Math.Round(drone2.getTimeToHome(), 2) + " seconds.");

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
