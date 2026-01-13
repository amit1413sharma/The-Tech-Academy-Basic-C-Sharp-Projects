using System; // Provides Console functionality

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathHelper class
            MathHelper helper = new MathHelper();

            // Call the method by passing in two numbers normally (by position)
            helper.DoMath(5, 10);

            // Call the method again, specifying parameters by name
            helper.DoMath(firstNumber: 7, secondNumber: 20);

            // Keep the console window open so the user can see the output
            Console.ReadLine();
        }
    }
}
