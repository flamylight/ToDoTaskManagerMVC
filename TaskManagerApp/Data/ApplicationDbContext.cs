namespace TaskManagerApp.Data;
using Microsoft.EntityFrameworkCore;
using Models;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<ToDoTask> Tasks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ToDoTask>().HasData(
            new ToDoTask
            {
                Id = 1,
                Title = "test1",
                Description = "Description 1",
                Status = "Active",
            },
            new ToDoTask
            {
                Id = 2,
                Title = "test2",
                Description = "Test 2",
                Status = "Completed",
            });
    }
}