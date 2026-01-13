using System; // Provides access to Console and basic system functionality

namespace MethodClassAssignment
{
    // This class contains a void method that performs a math operation
    class MathHelper
    {
        // This void method takes two integers as parameters
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (multiply by 2)
            int result = firstNumber * 2;

            // Display the result of the math operation on the first integer
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number displayed: " + secondNumber);
        }
    }
}
