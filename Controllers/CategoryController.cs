using Microsoft.AspNetCore.Mvc;
using RockyWebApp.Data;

namespace RockyWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var categories = _db.Category;
            return View(categories);
        }
    }
}
