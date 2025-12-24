using Microsoft.AspNetCore.Mvc;
using TaskManagerApp.Data;
using TaskManagerApp.Models;

namespace TaskManagerApp.Controllers;

public class TasksController: Controller
{
    private readonly ApplicationDbContext _db;

    public TasksController(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public IActionResult Index()
    {
        List<ToDoTask> tasks = _db.Tasks.ToList();
        
        return View(tasks);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ToDoTask task)
    {
        if (ModelState.IsValid)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
            return RedirectToAction("Index");   
        }
        return View(task);
    }
    
}