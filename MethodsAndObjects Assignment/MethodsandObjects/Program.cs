using System; // Provides Console functionality

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee()
            {
                FirstName = "Sample",   // Set the employee's first name
                LastName = "Student",   // Set the employee's last name
                Id = 1                  // Assign an ID value
            };

            // Call the SayName() method inherited from the Person class
            employee.SayName();

            // Keep the console window open so the output can be read
            Console.ReadLine();
        }
    }
}
