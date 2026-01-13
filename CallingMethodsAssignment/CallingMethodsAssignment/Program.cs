using System; // Provides Console functionality

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number to perform math operations on
            Console.Write("Enter a number: ");

            // Read the user input from the console
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the AddTen method and store the returned value
            int result1 = mathOps.AddTen(userNumber);

            // Display the result of AddTen
            Console.WriteLine("Number + 10 = " + result1);

            // Call the MultiplyByTwo method and store the returned value
            int result2 = mathOps.MultiplyByTwo(userNumber);

            // Display the result of MultiplyByTwo
            Console.WriteLine("Number * 2 = " + result2);

            // Call the SubtractFive method and store the returned value
            int result3 = mathOps.SubtractFive(userNumber);

            // Display the result of SubtractFive
            Console.WriteLine("Number - 5 = " + result3);

            // Keep the console window open so the user can read the output
            Console.ReadLine();
        }
    }
}
