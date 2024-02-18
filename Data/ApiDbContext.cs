using Microsoft.EntityFrameworkCore;
using prueba_api.Models;

namespace prueba_api.Data;

public class ApiDbContext : DbContext 
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }

    public DbSet<Driver> Drivers {get; set;}
}