using System; // Allows access to basic system functionality like Console

namespace ParsingEnumsAssignment
{
    // Create an enum that represents the days of the week
    // Enums are strongly-typed constants
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            try
            {
                // Read the user input as a string
                string userInput = Console.ReadLine();

                // Attempt to parse the string into the DaysOfWeek enum
                // The 'true' parameter ignores case sensitivity
                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If parsing is successful, display the parsed enum value
                Console.WriteLine($"You entered: {today}");
            }
            catch (Exception)
            {
                // If parsing fails, this message is shown to the user
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
