using blazor_api_task.Data;
using blazor_api_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace blazor_api_task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PatientData data)
        {
            if (data == null)
            {
                return BadRequest("Invalid data");
            }

            _context.Patients.Add(data);
            _context.SaveChanges();

            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PatientData data)
        {
            if (data == null)
            {
                return BadRequest("Invalid data");
            }

            var existingPatient = _context.Patients.Find(id);
            if (existingPatient == null)
            {
                return NotFound("Patient not found");
            }

            // Update properties of existingPatient with data
            existingPatient.P_name = data.P_name;
            existingPatient.P_age = data.P_age;
            existingPatient.P_disease = data.P_disease;

            _context.SaveChanges();
            return Ok(existingPatient);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var patients = _context.Patients.ToList();
            return Ok(patients);
        }
    }
}
