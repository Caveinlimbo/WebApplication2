using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
namespace WebApplication2.Controllers;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _db;

    public ProductController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        IEnumerable<Product> objProductList = _db.Products;
        return View(objProductList);
    }
}

