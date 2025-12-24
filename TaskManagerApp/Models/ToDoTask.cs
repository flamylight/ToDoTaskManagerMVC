using System.ComponentModel.DataAnnotations;

namespace TaskManagerApp.Models;

public class ToDoTask
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the name of the task")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter the description of the task")]
    [StringLength(100, MinimumLength = 5,
        ErrorMessage = "Description must be between 5 and 100 characters")]
    public string Description { get; set; } = string.Empty;
    
    public string Status { get; set; } = "Active";
}