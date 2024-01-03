using System.ComponentModel.DataAnnotations;

namespace blazor_api_task.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public List<Course> Courses { get; set; }
    }
}
