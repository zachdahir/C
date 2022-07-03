//Name: Zachary Dahir
//Date: 11-01-21
//Assignment 10

using System;

namespace assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create your string and initialize it here (as well as any other variables you think you need)
            string phrase =  "The Deliverator belongs to an elite order, a hallowed subcategory. He's got esprit up to here.";

            //Follow the bulleted points in the assignment here...
            Console.WriteLine("THe original string");
            Console.WriteLine(phrase);

            Console.WriteLine("==========");
            Console.WriteLine("Analysis:");
            Console.WriteLine("----------");

            Console.WriteLine("There are " + phrase.Length + " characters.");
            Console.WriteLine("There are " + getNumLetters(phrase, 'e') + " 'e's.");
            Console.WriteLine("There are " + getNumVowels(phrase) + " vowels.");

            Console.WriteLine();

            Console.WriteLine("Manipulation:");
            Console.WriteLine("----------");
            Console.WriteLine("The first ten characters of the sting are: " + phrase.Substring(0, 10));
            Console.WriteLine();
            Console.WriteLine("Replacing all the spaces with ':' : " + phrase.Replace(" ", ":"));
            Console.WriteLine();
            Console.WriteLine("Changing the string characters to upper case: " + phrase.ToUpper());
            Console.WriteLine();

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
                
        }
        
        //Here your required methods.  You will need to specify the return type after 
        //the word "static" and fill in the empty parenthese as required
        static int getNumLetters(string x, char y)
        {
            int numLetters = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y)
                {
                    numLetters++; 
                }
            }

            return numLetters;
        }
        
        static int getNumVowels(string x)
        {
           //Remember the hint: use getNumLetters in this method  
            x = x.ToLower();
            int vowels = 0;
            vowels += getNumLetters(x, 'a');
            vowels += getNumLetters(x, 'e');
            vowels += getNumLetters(x, 'i');
            vowels += getNumLetters(x, 'o');
            vowels += getNumLetters(x, 'u');

            return vowels;
        }
    }
}