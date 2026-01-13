using System; // Provides access to Console and system types

namespace PolymorphismAssignment
{
    // Abstract class representing a person
    abstract class Person
    {
        // Property for the person's first name
        public string firstName { get; set; }

        // Property for the person's last name
        public string lastName { get; set; }

        // Abstract method that must be implemented by derived classes
        public abstract void SayName();
    }
}
