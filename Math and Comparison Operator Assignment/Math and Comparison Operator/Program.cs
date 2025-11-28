using System;

class Program
{
    static void Main(string[] args)
    {
        // Print program title
        Console.WriteLine("Anonymous Income Comparison Program");

        // ---------------------------------------------
        // Person 1 Inputs
        // ---------------------------------------------
        Console.WriteLine("\nPerson 1");

        // Ask for hourly rate
        Console.Write("Enter hourly rate: ");
        // Convert the input to a decimal (good for money calculations)
        decimal p1Rate = Convert.ToDecimal(Console.ReadLine());

        // Ask for hours worked per week
        Console.Write("Enter hours worked per week: ");
        decimal p1Hours = Convert.ToDecimal(Console.ReadLine());

        // Calculate annual salary (rate × hours × 52 weeks)
        decimal p1AnnualSalary = p1Rate * p1Hours * 52;


        // ---------------------------------------------
        // Person 2 Inputs
        // ---------------------------------------------
        Console.WriteLine("\nPerson 2");

        Console.Write("Enter hourly rate: ");
        decimal p2Rate = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter hours worked per week: ");
        decimal p2Hours = Convert.ToDecimal(Console.ReadLine());

        // Calculate Person 2's annual salary
        decimal p2AnnualSalary = p2Rate * p2Hours * 52;


        // ---------------------------------------------
        // Output the results
        // ---------------------------------------------

        // Show Person 1 annual salary
        Console.WriteLine("\nAnnual salary of Person 1:");
        Console.WriteLine(p1AnnualSalary);

        // Show Person 2 annual salary
        Console.WriteLine("\nAnnual salary of Person 2:");
        Console.WriteLine(p2AnnualSalary);

        // Compare salaries and print true/false
        Console.WriteLine("\nPerson 1 makes more money than Person 2:");
        Console.WriteLine(p1AnnualSalary > p2AnnualSalary);

        // Pause console until user presses Enter
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
