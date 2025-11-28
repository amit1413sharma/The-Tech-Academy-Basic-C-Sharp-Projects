using System;   // Gives access to the Console class

class Program
{
    static void Main(string[] args)
    {
        // Print the program greeting message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // ---------------------------------------------------------
        // Ask for package weight
        // ---------------------------------------------------------
        Console.WriteLine("Please enter the package weight:");
        // Convert user input to a decimal for accurate calculations
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // If package is too heavy, stop the program and display message
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;     // Ends the program immediately
        }

        // ---------------------------------------------------------
        // Ask for package dimensions
        // ---------------------------------------------------------
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check total dimensions
        decimal dimensionTotal = width + height + length;

        // If dimensions exceed 50, stop program
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;     // Ends the program immediately
        }

        // ---------------------------------------------------------
        // Calculate the shipping quote
        // ---------------------------------------------------------

        // Multiply dimensions together, then multiply by weight
        decimal volume = width * height * length;
        decimal quote = (volume * weight) / 100;

        // Print the quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

        // Thank the user
        Console.WriteLine("Thank you!");

        // Keep the console window open until user presses Enter
        Console.ReadLine();
    }
}
