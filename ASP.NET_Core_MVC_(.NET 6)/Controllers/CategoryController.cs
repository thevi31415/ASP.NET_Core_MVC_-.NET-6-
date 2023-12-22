using ASP.NET_Core_MVC__.NET_6_.Data;
using ASP.NET_Core_MVC__.NET_6_.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC__.NET_6_.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategrogyList = _db.Categories;

            return View(objCategrogyList);
        }
    }
}
