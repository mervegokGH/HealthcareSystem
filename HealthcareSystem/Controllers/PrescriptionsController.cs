using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HealthcareSystem.Data;
using HealthcareSystem.Models;

namespace HealthcareSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrescriptionsController : ControllerBase
    {
        private readonly HealthcareContext _context;
        public PrescriptionsController(HealthcareContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _context.Prescriptions.Include(p => p.Patient).ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Prescribe(Prescription prescription)
        {
            _context.Prescriptions.Add(prescription);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = prescription.Id }, prescription);
        }
    }
}
