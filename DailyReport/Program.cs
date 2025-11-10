using System; // Gives access to basic C# functionality like Console

namespace AcademyDailyReport
{
    // Program class contains the Main method (entry point of the application)
    class Program
    {
        static void Main(string[] args)
        {
            // Print the school name
            Console.WriteLine("Academy of Learning Career College");

            // Print the report title
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine(); // Blank line for readability

            // Ask for the student's name (string)
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            // Ask which course the student is on (string)
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask for the current page number (int)
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help (bool: true/false)
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask for positive experiences (string)
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            // Ask for additional feedback (string)
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string additionalFeedback = Console.ReadLine();

            // Ask how many hours the student studied (double)
            Console.Write("How many hours did you study today? ");
            double hoursStudied = Convert.ToDouble(Console.ReadLine());

            // End message
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Optional: keep console window open until user presses Enter
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
