using System.ComponentModel.DataAnnotations;

namespace blazor_api_task.Models
{
    public class PatientData
    {
        [Key]
        public int Id { get; set; }
        public string P_name { get; set; }
        public int P_age { get; set; }
        public string P_disease { get; set; }
    }
}
