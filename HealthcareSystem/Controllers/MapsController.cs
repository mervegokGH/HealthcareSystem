using Microsoft.AspNetCore.Mvc;
using HealthcareSystem.Services;

namespace HealthcareSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MapsController : ControllerBase
    {
        private readonly GoogleMapsService _mapsService;

        public MapsController(GoogleMapsService mapsService)
        {
            _mapsService = mapsService;
        }

        [HttpGet("geocode")]
        public async Task<IActionResult> Geocode([FromQuery] string address)
        {
            var result = await _mapsService.GetLocationCoordinates(address);
            return Ok(result);
        }
    }
}
