using System.ComponentModel.DataAnnotations;

namespace StudentCodeFirstApp
{
    // This class becomes a database table (Students) in Code First.
    public class Student
    {
        // Primary Key by convention when named "Id" or "<ClassName>Id".
        public int Id { get; set; }

        // Required means NOT NULL in the database.
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // Optional example field.
        public int Age { get; set; }
    }
}
