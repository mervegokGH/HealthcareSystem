using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthcareSystem.Data;
using HealthcareSystem.Models;

namespace HealthcareSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly HealthcareContext _context;
        public AppointmentsController(HealthcareContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _context.Appointments.Include(a => a.Patient).ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Schedule(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = appointment.Id }, appointment);
        }
    }
}
