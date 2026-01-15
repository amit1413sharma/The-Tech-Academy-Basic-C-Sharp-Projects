using System.Data.Entity;

namespace StudentCodeFirstApp
{
    // DbContext manages the database connection and maps classes to tables. :contentReference[oaicite:4]{index=4}
    public class StudentContext : DbContext
    {
        // This name must match the connection string name in App.config.
        public StudentContext() : base("StudentDbConn")
        {
            // Ensures the database is created if it does not already exist. :contentReference[oaicite:5]{index=5}
            Database.SetInitializer(new CreateDatabaseIfNotExists<StudentContext>());
        }

        // DbSet represents a table in the database.
        public DbSet<Student> Students { get; set; }
    }
}
