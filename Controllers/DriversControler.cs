using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba_api.Data;
using prueba_api.Models;

namespace prueba_api.Controllers;

[ApiController]
[Route("[controller]")]
public class DriversController : ControllerBase
{

    private readonly ILogger<DriversController> _logger;
    private readonly ApiDbContext _context;
    public DriversController(ILogger<DriversController> logger, ApiDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet (Name = "GetAllDrivers")]
    public async Task<IActionResult> Get()
    {
        var driver = new Driver()
        {
            Name = "Javi",
            DriverNumber = 3423
        };

        _context.Add(driver);
        await _context.SaveChangesAsync();

        var AllDriver = await _context.Drivers.ToListAsync();
        return Ok(AllDriver);
    }
    
}

