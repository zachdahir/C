//Name: Zachary Dahir
//Date: 9-28-21
//Assignment 5

using System;

namespace Assignment5
{
    class assignment5
    {
        static void Main(string[] args)
        {
            //Declare your variables here
           int i, j;
            
            //Prompt the user per the example and store that in one of your variables
            Console.Write("Enter the maximum value for your pyramid (0 to quit): ");
            int input = Convert.ToInt32(Console.ReadLine());
            int inputDown = input - 1;
            //Your outer "main" while loop that uses the sentinel
            while(input != 0)
            {
               
                //Here we use nested for loops to draw the "increasing" part
                for (i = 1; i <= input; i++) 
                {
                    
                    //This for loop outputs your asterisks
                    for (j = 1; j <= i; j++)
                    {
                        // Code to output astersisks here
                        Console.Write("*");  
                    }
                    
                    //Don't forget to display the number of asterisks at the end of the line
                    Console.Write(i);
					Console.WriteLine();
                }
                
                
                //Here we use nested for loops to draw the "decreasing" part
                for (i = inputDown; i >= 1; i--)
                {
                    for (j = 1; j <= i; j++)
                    {
                        // Code to output astersisks here
                        Console.Write("*");
                    }
                    
                    //Don't forget to display the number of asterisks at the end of the line
                    Console.Write(i);
					Console.WriteLine();
                }
                
                //Since this is right before we loop back to our "main" while loop,
                //we need to re-prompt the user so that we can change the value of the
                //variable that we're using in our "main" while loop
            Console.Write("Enter the maximum value for your pyramid (0 to quit): ");
            input = Convert.ToInt32(Console.ReadLine());
            inputDown = input - 1;
            }
            
        } // end Main
 
    } // end class
    
} // end namespace