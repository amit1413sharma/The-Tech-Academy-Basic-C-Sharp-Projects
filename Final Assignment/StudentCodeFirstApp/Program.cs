using System;
using System.Linq;

namespace StudentCodeFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EF6 Code First - Student Database Demo");

            using (var db = new StudentContext())
            {
                // Create a new student object in C# (Code First model).
                var student = new Student
                {
                    FirstName = "Sample",
                    LastName = "Student",
                    Age = 20
                };

                // Add the student to the Students table (DbSet).
                db.Students.Add(student);

                // SaveChanges sends INSERT/UPDATE/DELETE statements to the database.
                db.SaveChanges();

                // Show proof it worked by reading the total number of students.
                int count = db.Students.Count();
                Console.WriteLine($"Saved 1 student. Total students in DB now: {count}");

                // Show the last inserted student (by Id).
                var lastStudent = db.Students.OrderByDescending(s => s.Id).FirstOrDefault();
                if (lastStudent != null)
                {
                    Console.WriteLine($"Last Student: {lastStudent.Id} - {lastStudent.FirstName} {lastStudent.LastName}, Age {lastStudent.Age}");
                }
            }

            Console.WriteLine("Done. Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
