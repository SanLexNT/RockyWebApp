using Microsoft.AspNetCore.Mvc;
using RockyWebApp.Data;
using RockyWebApp.Models;

namespace RockyWebApp.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly AppDbContext _db;
        public ApplicationTypeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var types = _db.ApplicationType;
            return View(types);
        }

        //GET - Create
        public IActionResult Create()
        {
            return View();
        }

        //POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType applicationType)
        {
            _db.ApplicationType.Add(applicationType);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Edit - Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var type = _db.ApplicationType.Find(id);
            if (type == null)
            {
                return NotFound();
            }
            return View(type);
        }
        //Edit - Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ApplicationType type)
        {
            if (ModelState.IsValid)
            {
                _db.ApplicationType.Update(type);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(type);
        }

        //Delete - Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var type = _db.ApplicationType.Find(id);
            if (type == null)
            {
                return NotFound();
            }
            return View(type);
        }
        //Delete - Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var type = _db.ApplicationType.Find(id);
            if (type == null)
                return NotFound();

            _db.ApplicationType.Remove(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
