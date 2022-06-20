using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.Data;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<WorkerInfo> WorkerInfo { get; set; }
    
}
    

