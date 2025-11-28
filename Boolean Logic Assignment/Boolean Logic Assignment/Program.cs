using System;  // Gives access to basic system functionality like Console

class Program
{
    static void Main(string[] args)
    {
        // Print the program header/title
        Console.WriteLine("Car Insurance Approval Program");
        Console.WriteLine("--------------------------------\n");

        // ---------------------------------------------
        // Ask for the applicant's age
        // ---------------------------------------------
        Console.WriteLine("What is your age?");
        // Read age as text from the user, then convert it to an integer
        int age = Convert.ToInt32(Console.ReadLine());

        // ---------------------------------------------
        // Ask if the applicant has ever had a DUI
        // ---------------------------------------------
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        // Read DUI answer as text, then convert "true"/"false" into a boolean value
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // ---------------------------------------------
        // Ask how many speeding tickets the applicant has
        // ---------------------------------------------
        Console.WriteLine("How many speeding tickets do you have?");
        // Read the number of tickets as text, then convert it to an integer
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // ---------------------------------------------
        // Apply the qualification rules
        // ---------------------------------------------

        // Rule 1: Applicant must be over 15 years old
        bool isOver15 = age > 15;

        // Rule 2: Applicant must NOT have any DUIs
        bool hasNoDUI = (hasDUI == false);

        // Rule 3: Applicant must NOT have more than 3 speeding tickets
        bool hasAcceptableTickets = speedingTickets <= 3;

        // Final result: applicant is qualified only if ALL three conditions are true
        bool isQualified = isOver15 && hasNoDUI && hasAcceptableTickets;

        // ---------------------------------------------
        // Output the result
        // ---------------------------------------------

        // Echo back the answers (optional but helpful for clarity)
        Console.WriteLine("\nSummary of your information:");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Had DUI: " + hasDUI);
        Console.WriteLine("Number of speeding tickets: " + speedingTickets);

        // Print "Qualified?" label, then print the boolean result underneath
        Console.WriteLine("\nQualified?");
        Console.WriteLine(isQualified);

        // Keep console window open until user presses Enter
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
