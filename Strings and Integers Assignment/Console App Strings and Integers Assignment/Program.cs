using System;                    // Provides Console, Exception, and basic system types
using System.Collections.Generic; // Provides List<T>

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers to divide (sample values for the assignment)
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            // Ask the user for a number to divide each number in the list by
            Console.Write("Enter a number to divide each list number by: ");

            // Read the user's input as a string (it may be invalid, so we don't parse yet outside try/catch)
            string userInput = Console.ReadLine();

            // Put the divide loop in a try/catch so we can handle bad input and division errors safely
            try
            {
                // Convert the user's input to an integer (can throw FormatException or OverflowException)
                int divisor = Convert.ToInt32(userInput);

                // Loop through each integer in the list
                for (int i = 0; i < numbers.Count; i++)
                {
                    // Divide the current list number by the user's number (can throw DivideByZeroException)
                    int result = numbers[i] / divisor;

                    // Display the result to the screen
                    Console.WriteLine($"{numbers[i]} / {divisor} = {result}");
                }
            }
            catch (Exception ex)
            {
                // Display the error message (handles strings, zero, overflow, etc.)
                Console.WriteLine("An error occurred:");
                Console.WriteLine(ex.Message);
            }

            // This message proves the program continued after the try/catch block
            Console.WriteLine("\nThe program has emerged from the try/catch block and continued executing.");

            // Keep the console window open so the user can read the output
            Console.ReadLine();
        }
    }
}
