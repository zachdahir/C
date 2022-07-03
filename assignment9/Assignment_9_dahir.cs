//Name: Zachary Dahir
//Date: 10-26-21
//Assignment 9

using System;

namespace Assignment9
{
    class assignment9
    {
        static void Main(string[] args)
        {
            // Declare your initialized arrays here
            string[] droneType = new string[] {"Tricopter", "Quadcopter", "Hexcopter", "Octocopter", "Turbine\t", "StackedTri"};
            int[] numProps = new int[] {3, 4, 6, 8, 1, 6};
            double[] batteryVolts = new[] {11.1, 14.8, 16.6, 22.2, 12.0, 16.6};

            //Call printData
            printData(droneType, numProps, batteryVolts);
            Console.WriteLine("");
            
            //Get user input
            Console.WriteLine("Which drone would you like to super charge? Enter the number: ");
            int charge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            //Super charge a drone
            superCharge(ref batteryVolts, charge);
           
            //Tell the user which drone was super charged
            Console.WriteLine(droneType[charge] + " has been supercharged.");
            Console.WriteLine("");
           
            //Call printData
            printData(droneType, numProps, batteryVolts);
          
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        } // end Main
        
        //Here your required methods.  You will need to specify the return type after 
        //the word "static" and fill in the empty parenthese as required
        
        static void printData(string[] droneType, int[] numProps, double[] batteryVolts)
        {
            Console.WriteLine("Drone");
            Console.WriteLine("Number" +  "\t" + "Drone Type" + "\t" + "Props" + "\t" + "Volts" + "\t" + "Flight Time");

            for (int i = 0; i < 6; i++)      
            {
                Console.WriteLine(i + "\t" + droneType[i] + "\t" + numProps[i] + "\t" + batteryVolts[i] + "\t" + calculateFlightTime(batteryVolts, i));
            }    
        }
        
        static double calculateFlightTime(double[] arr, int x)
        {
            double flightTime = arr[x] * 1.085;
            return flightTime;
        }
        
        static void superCharge(ref double[] arr, int x)
        {
            arr[x] *= 1.6;
        }
 
    } // end class
    
} // end namespace