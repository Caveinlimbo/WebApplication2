using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
namespace WebApplication2.Controllers;

public class WorkerController : Controller
{
    private readonly ApplicationDbContext _db;

    public WorkerController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        IEnumerable<Worker> objWorkerList = _db.Workers;
        return View(objWorkerList);
    }
}