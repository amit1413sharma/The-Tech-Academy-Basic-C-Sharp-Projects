using System;            // Provides basic system functionality (Console, etc.)
using System.Text;       // Needed for StringBuilder

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------------------------
        // 1. Concatenate three strings
        // ---------------------------------------------------------

        // Create three separate strings
        string part1 = "Hello, ";
        string part2 = "welcome to ";
        string part3 = "C# programming!";

        // Concatenate the three strings into one complete sentence
        string combinedString = part1 + part2 + part3;

        // Display the concatenated result
        Console.WriteLine(combinedString);


        // ---------------------------------------------------------
        // 2. Convert a string to uppercase
        // ---------------------------------------------------------

        // Create a string to convert
        string lowerCaseString = "this sentence will be uppercase.";

        // Convert to uppercase using ToUpper()
        string upperCaseString = lowerCaseString.ToUpper();

        // Display the uppercase result
        Console.WriteLine(upperCaseString);


        // ---------------------------------------------------------
        // 3. Create a StringBuilder and build a paragraph
        // ---------------------------------------------------------

        // Create a new StringBuilder to build multiple sentences efficiently
        StringBuilder paragraph = new StringBuilder();

        // Add sentences to the paragraph one at a time
        paragraph.Append("This is the first sentence of the paragraph. ");
        paragraph.Append("StringBuilder is useful when working with large amounts of text. ");
        paragraph.Append("It allows you to add, modify, or remove content without creating multiple string objects. ");
        paragraph.Append("This results in better performance and memory usage. ");

        // Display the final built paragraph
        Console.WriteLine(paragraph.ToString());


        // Keep the console open until the user presses Enter
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
