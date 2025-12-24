namespace TaskManagerApp.Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<Task> Tasks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Task>().HasData(
            new Task
            {
                Id = 1,
                Title = "test1",
                Description = "Description 1",
                IsCompleted = false,
            },
            new Task
            {
                Id = 2,
                Title = "test2",
                Description = "Test 2",
                IsCompleted = true,
            });
    }
}