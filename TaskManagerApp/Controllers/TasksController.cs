using Microsoft.AspNetCore.Mvc;

namespace TaskManagerApp.Controllers;

public class TasksController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}