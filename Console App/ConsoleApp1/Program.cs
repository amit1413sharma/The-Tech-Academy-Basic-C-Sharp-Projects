using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------------
        // 1. Multiply user input by 50
        // ---------------------------------------------

        // Prompt user for input
        Console.WriteLine("Enter a number to multiply by 50:");
        // Convert input to a long so it can handle values > 10,000,000
        long multiplyInput = Convert.ToInt64(Console.ReadLine());
        // Multiply input by 50
        long multiplyResult = multiplyInput * 50;
        // Display result
        Console.WriteLine("Result of multiplication: " + multiplyResult);


        // ---------------------------------------------
        // 2. Add 25 to user input
        // ---------------------------------------------

        Console.WriteLine("\nEnter a number to add 25:");
        long addInput = Convert.ToInt64(Console.ReadLine());
        // Add 25
        long addResult = addInput + 25;
        Console.WriteLine("Result after adding 25: " + addResult);


        // ---------------------------------------------
        // 3. Divide user input by 12.5
        // ---------------------------------------------

        Console.WriteLine("\nEnter a number to divide by 12.5:");
        // Use double to allow decimal numbers
        double divideInput = Convert.ToDouble(Console.ReadLine());
        // Perform division
        double divideResult = divideInput / 12.5;
        Console.WriteLine("Result of division: " + divideResult);


        // ---------------------------------------------
        // 4. Check if user input is greater than 50
        // ---------------------------------------------

        Console.WriteLine("\nEnter a number to check if it is greater than 50:");
        long checkInput = Convert.ToInt64(Console.ReadLine());
        // Boolean result: true if input > 50, false otherwise
        bool isGreaterThanFifty = checkInput > 50;
        Console.WriteLine("Is your number greater than 50? " + isGreaterThanFifty);


        // ---------------------------------------------
        // 5. Divide input by 7 and print the remainder
        // ---------------------------------------------

        Console.WriteLine("\nEnter a number to divide by 7 and get the remainder:");
        long remainderInput = Convert.ToInt64(Console.ReadLine());
        // % operator gives the remainder after division
        long remainder = remainderInput % 7;
        Console.WriteLine("The remainder when divided by 7 is: " + remainder);


        // Keep console open until user presses Enter
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
