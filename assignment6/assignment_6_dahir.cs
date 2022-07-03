//Name: Zachary Dahir
//Date: 10-08-21
//Assignment 6

using System;

namespace Assignment6
{
    class assignment6
    {
        static void Main(string[] args)
        {
            // Declare your variables here - 2 random number generators
            // seeded as instructed and integer variables to store your two pairs
            // of x and y values.  You'll also need an integer to use in your for
            // loop. You may also choose to create a double for your
            // distance calculation
            //
            // NOTE: Your random number generators must be declared here.  DO NOT
            // declare then inside your for loop!
            
            Random xGen = new Random(243);
            Random yGen = new Random(342);
            
            double distance;
            int pairs;
            int x1;
            int x2;
            int y1;
            int y2;
            // Prompt the user for input, and use a for loop to generate the required
            // table as depicted in the example
            Console.WriteLine("How many pairs of x,y points would you like?");
            pairs = Convert.ToInt32(Console.ReadLine());
            
            //Set up your table header here
            Console.WriteLine("Point 1 \t Point 2\tBig x\tBig y\tDistance");
            Console.WriteLine("======= \t =======\t=====\t=====\t========");
            
            //Use this for loop to generate your point pairs, find the maximum
            //x and y values, calculate the distance between your point pairs, 
            //and output your results as in the example
            for (int i = 0; i < pairs; i++)
            {
                // Generate your points, find your maximums, find your distances, and display here
                
                x1 = xGen.Next(100);
                x2 = xGen.Next(100);
                y1 = yGen.Next(100);
                y2 = yGen.Next(100);

                distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

                Console.WriteLine("(" + x1 + ", " + y1 + ") \t (" + x2 + ", " + y2 + ")\t" + Math.Max(x1, x2) + "\t" + Math.Max(y1, y2) + "\t" + distance);

            }
            
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        } // end Main
 
    } // end class
    
} // end namespace