using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
namespace WebApplication2.Controllers;

public class WorkerInfoController : Controller
{
    private readonly ApplicationDbContext _db;

    public WorkerInfoController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        IEnumerable<WorkerInfo> objWorkerInfoList = _db.WorkerInfo;
        return View(objWorkerInfoList);
    }
}