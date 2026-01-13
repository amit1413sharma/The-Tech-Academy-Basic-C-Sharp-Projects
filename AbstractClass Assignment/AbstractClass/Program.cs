using System; // Provides Console functionality

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee()
            {
                firstName = "Sample",   // Assign first name
                lastName = "Student"    // Assign last name
            };

            // Call the SayName method on the Employee object
            employee.SayName();

            // Keep the console window open so output can be read
            Console.ReadLine();
        }
    }
}
