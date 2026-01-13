using System; // Provides Console functionality

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            // The actual object is an Employee, which implements IQuittable
            IQuittable quittableEmployee = new Employee()
            {
                firstName = "Sample",   // Assign first name
                lastName = "Student"    // Assign last name
            };

            // Call the Quit method using the interface reference
            quittableEmployee.Quit();

            // Keep the console window open so output can be read
            Console.ReadLine();
        }
    }
}
