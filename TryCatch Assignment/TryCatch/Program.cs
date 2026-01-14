using System; // Provides access to Console and DateTime

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Please enter your age:");

            try
            {
                // Read the user input as a string
                string input = Console.ReadLine();

                // Convert the input string to an integer
                int age = Convert.ToInt32(input);

                // Check if the age is zero or negative
                if (age <= 0)
                {
                    // Throw an exception if the age is invalid
                    throw new ArgumentException("Age must be greater than zero.");
                }

                // Get the current year from the system
                int currentYear = DateTime.Now.Year;

                // Calculate the year the user was born
                int birthYear = currentYear - age;

                // Display the calculated birth year
                Console.WriteLine("You were born in: " + birthYear);
            }
            catch (ArgumentException)
            {
                // Handles cases where age is zero or a negative number
                Console.WriteLine("Age must be a positive number greater than zero.");
            }
            catch (Exception)
            {
                // Handles all other exceptions (non-numeric input, overflow, etc.)
                Console.WriteLine("An error occurred. Please enter a valid number.");
            }

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
