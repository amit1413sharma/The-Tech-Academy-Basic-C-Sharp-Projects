using System; // Provides Console functionality

namespace PolymorphismAssignment
{
    // Employee class inherits from Person and implements IQuittable
    class Employee : Person, IQuittable
    {
        // Override of the abstract SayName method from Person
        public override void SayName()
        {
            // Display the employee's full name
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine(firstName + " " + lastName + " has quit the job.");
        }
    }
}
