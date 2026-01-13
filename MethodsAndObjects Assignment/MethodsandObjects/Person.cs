using System; // Provides access to Console and basic system functionality

namespace MethodsAndObjectsAssignment
{
    // The Person class represents a basic person
    class Person
    {
        // Property to store the person's first name
        public string FirstName { get; set; }

        // Property to store the person's last name
        public string LastName { get; set; }

        // Void method that displays the person's full name
        public void SayName()
        {
            // Write the full name to the console in the required format
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
