//Name: Zachary Dahir
//Date: 9-22-21
//Assignment 4

using System;

namespace Assignment4
{
    class assignment4
    {
        static void Main(string[] args)
        {
            //Declare your variables here
           int counter = 0; 
           int innerCounter = 0; 
           int inputDown;

            //Prompt the user per the example and store that in one of your variables
            Console.Write("Enter the maximum value for your pyramid (0 to quit): ");
            int input = Convert.ToInt32(Console.ReadLine());
            inputDown = input - 1;

            //Your outer "main" while loop that uses the sentinel
            while(input != 0)
            {
                counter = 0; 
                //Here we use nested while loops to draw the "increasing" part
                while (counter < input)
                {
                    innerCounter = 0;
                    //This while loop outputs your asterisks - see the example
                    //on our Blackboard for this week for outputting sequences;
                    while (innerCounter <= counter)
                    {
                        // Code to output astersisks here
                        Console.Write("*");
                        innerCounter++;  
                    }
                    // See the example about outputting sequences for what should go here
                    Console.WriteLine();
                    counter++;
                }
                
                
                //You may need to do something with a variable here before 
                //the next while loops
                counter = 0; 
                innerCounter = 0; 

                //Here we use nested while loops to draw the "decreasing" part
                while (counter < inputDown)
                {
                   innerCounter = inputDown;
                    while (innerCounter > counter)
                    {
                        // Code to output astersisks here
                        Console.Write("*");
                        innerCounter--;
                    }
                    // See the example about outputting sequences for what should go here
                    Console.WriteLine();
                    counter++;
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