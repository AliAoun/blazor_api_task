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
    }
}
