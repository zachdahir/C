// Name: Zachary Dahir
// Date: 10/23/21
// Assignment: Assignment 8

using System;

namespace Assignment8Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			//Declare your variables per the instructions
			int[] array = new int[10];
			int evenSum = 0;
			int oddSum = 0;
			int totalSum = 0;
			int min = 1000;
			int max = array[0];

			//Create and instantiate your random number generator
			//using the correct seed
			Random rInt = new Random(243);

			//Use a for loop to fill your array with 10 random integers,
			//display those values to the screen, and perform the directed
			//calculations
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rInt.Next(1, 101);

				if (array[i] % 2 == 0)
                	evenSum += array[i];
            	else
                	oddSum += array[i];

				if (array[i] > max)
					max = array[i];

				if (array[i] < min)
					min = array[i];

				totalSum  = oddSum + evenSum;

				Console.WriteLine(array[i]);
			}
            
			//After your for loop, display the information shown in the example 
			//(which means you need to complete the required calculation for the
			//average of the array values after the for loop, as well)
			double len = Convert.ToDouble(array.Length);
			double average = totalSum / len;

			Console.WriteLine("The first element in the array is " + array[0]);
			Console.WriteLine("The last element in the array is " + array[array.Length - 1]);
			Console.WriteLine("The minimum value in the array is " + min);
			Console.WriteLine("The maximum value in the array is " + max);
			Console.WriteLine("The sum of  the values in the array is " + totalSum);
			Console.WriteLine("The sum of  the even values in the array is " + evenSum);
			Console.WriteLine("The sum of  the odd values in the array is " + oddSum);  
			Console.WriteLine("The average of  the values in the array is " + average);
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
			
        }
           
    }
}
