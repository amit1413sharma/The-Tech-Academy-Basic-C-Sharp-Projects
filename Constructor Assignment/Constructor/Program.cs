using System; // Provides access to Console and basic system functionality

namespace ConstructorAssignment
{
    class Person
    {
        // Create a const variable
        // Constants must be assigned at compile time and cannot be changed
        public const string Species = "Human";

        // Property to store the person's name
        public string Name { get; set; }

        // Property to store the person's age
        public int Age { get; set; }

        // Parameterless constructor
        // This constructor calls the parameterized constructor using constructor chaining
        public Person() : this("Unknown", 0)
        {
            // No additional code is needed here because values are set in the chained constructor
        }

        // Parameterized constructor
        // This constructor accepts values for name and age
        public Person(string name, int age)
        {
            // Assign constructor parameters to properties
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable using the 'var' keyword
            // The compiler determines the type at compile time
            var person = new Person("Amit", 32);

            // Print the constant value to the console
            Console.WriteLine("Species: " + Person.Species);

            // Print the person's details to the console
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);

            // Keeps the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
