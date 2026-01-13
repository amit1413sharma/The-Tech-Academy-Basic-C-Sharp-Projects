using System; // Provides access to Console functionality

namespace AbstractClassAssignment
{
    // Employee class inherits from the abstract Person class
    class Employee : Person
    {
        // Implementation of the abstract SayName method
        public override void SayName()
        {
            // Display the employee's full name in the required format
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
