using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create the second Employee object
            Employee emp2 = new Employee
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two employees using the overloaded == operator
            bool areEqual = emp1 == emp2;

            // Display the comparison result
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Pause the console window so the output can be read
            Console.ReadLine();
        }
    }
}
