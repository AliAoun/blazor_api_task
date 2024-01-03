using blazor_api_task.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_api_task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PatientData> Patients { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Student { get; set; }


        var studentsWithLessThan50PercentMarks = AppDbContext.Student
    .Where(s => s.Courses.Any(c => c.Marks < 50))
    .ToList();

        // Query for students with 50-85% marks
        var studentsWith50To85PercentMarks = AppDbContext.Student
            .Where(s => s.Courses.Any(c => c.Marks >= 50 && c.Marks <= 85))
            .ToList();

        // Query for students with 85%+ marks
        var studentsWith85PlusPercentMarks = AppDbContext.Student
            .Where(s => s.Courses.All(c => c.Marks >= 85))
            .ToList();


    }
}
