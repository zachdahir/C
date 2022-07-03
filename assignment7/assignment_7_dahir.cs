// Name: Zachary Dahir
// Date: 10-13-21
// Assignment: C# console applicaton that will find the hypotenuse and angle theta for variously randomly generated values of a and b

using System;

namespace Assignment7Methods
{
    class Program
    {
        static void Main(string[] args)
        {
			//Declare your variables per the instructions
			int a = 0;
            int b = 0;
            double c = 0;
            double theta = 0;
            double degrees = 0;
			
			//Create and instantiate your random number generator
			//using the correct seed
			Random rGen = new Random(243);
			
			//Output your header here
			Console.WriteLine("a\tb\tc\trad\tdeg");
            Console.WriteLine("===\t===\t===\t===\t===");
			
			//Use for loop to do 10 line items
			for (int i = 0; i < 10; i++)
			{
			    //Assign random values your integer variables
			    a = rGen.Next(1, 10);
                b = rGen.Next(1, 10);

			    //Find and store you hypotenuse value using your method
			    c = pythagoras(a, b);

			    //Find and store your theta - REMEBER TO USE ref!
                findAngle(ref theta, a, c);

			    //Convert your theta to degrees
                degrees = radiansToDegrees(theta);

			    //Output your data - remember to limit your decimals!
			    Console.WriteLine(a + "\t" + b + "\t" + Math.Round(c,2)  + "\t" + Math.Round(theta,2) + "\t" + Math.Round(degrees,2));
			}
			
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
			
        } //end Main
        
        
        //Method declarations below... DO NOT MOVE THESE!
         
        public static double pythagoras(int a, int b)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return hypotenuse;
        }
        
        //This method should take a pass-by-reference variable!
        public static void findAngle(ref double theta, int a, double c)
        {
            theta = Math.Acos(a / c);       
        }
        
        public static double radiansToDegrees(double theta)
        {
            double deg = theta * (180 / Math.PI);
            return deg;
        }
    }
}
