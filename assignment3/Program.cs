using System;

namespace assignment3
{
    class ValueChecker
    {
            // Declare the required variables (don't 
            // forget to initialize you booleans as 
            // directed).
            private int num;
            private bool isZero;
            private bool isNegative;
            private bool isPositive;
            
            //The constructor - note there is no empty constructor
            //for this assignment
            public ValueChecker(int n)
            {
                num = n;
            }
			
			
			// The printIt method where you will check the inputted value,
			// assign your boolean values as needed, and print out your
			//results
            public void printIt()
            {
                if (num < 0) 
                {
                    isNegative = true;
                }
                else if (num == 0)
                {
                    isZero = true;
                }
                else
                {
                    isPositive = true;
                }

                Console.WriteLine("Analysis of integer value: " + num);
				Console.WriteLine("Value is zero: " + isZero);
                Console.WriteLine("Value is negitive: " + isNegative);
                Console.WriteLine("Value is positive: " + isPositive);			    
            }
    } //End class
    
    
    class assignment3
    {
        public static void Main(string[] args)
        {
                //Prompt the user for input
                int hold;
                Console.WriteLine("Please enter an integer value: ");
                hold = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
				
				//Instantiate your ValueChecker class with the user input
				ValueChecker num1 = new ValueChecker(hold);
			
				//Call your object's printIt() method
                num1.printIt();
                
				Console.WriteLine("\nPress Enter to continue.");
				Console.ReadLine();
        }
        
    } //End class
} //End namespace
