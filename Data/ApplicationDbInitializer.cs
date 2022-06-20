using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.Data;

public class ApplicationDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices
            .CreateScope();
        var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

        context?.Database.EnsureCreated();

        if (!context.Workers.Any())
        {
            context.Workers.AddRange(new List<Worker>());
            {
                new Worker() {WorkerName = "Jane Austen"};
                new Worker() {WorkerName = "Charles Dickens"};
                new Worker() {WorkerName = "Miguel de Cervantes"};
                
            }
            context.SaveChanges(); 

        }

        void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Worker>()
            .ToTable("Workers");
        modelBuilder.Entity<Worker>()
            .Property(s => s.WorkerName)
            .IsRequired(true);
        modelBuilder.Entity<Student>()
            .HasData(
                new Worker
                {
                    
                    WorkerName  = "John Doe",
                },
                new Worker
                {
                    WorkerName = "Jane Doe",
                }
            );
    }
    }
}