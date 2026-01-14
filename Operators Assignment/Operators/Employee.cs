using System;

namespace OperatorsAssignment
{
    // Employee class defines the structure for employee objects
    class Employee
    {
        // Property to store employee ID
        public int Id { get; set; }

        // Property to store employee first name
        public string FirstName { get; set; }

        // Property to store employee last name
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects reference the same memory location, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either object is null, they are not equal
            if (emp1 is null || emp2 is null)
                return false;

            // Compare employees by their Id property
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (required pair for ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator result
            return !(emp1 == emp2);
        }

        // Override Equals method to match == operator logic
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            if (obj is Employee employee)
            {
                // Compare Id values
                return this.Id == employee.Id;
            }
            return false;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            // Use Id to generate hash code
            return Id.GetHashCode();
        }
    }
}
