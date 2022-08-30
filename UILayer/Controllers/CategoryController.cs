using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class CategoryController : Controller
    {
        readonly CategoryManager _categoryManager= new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var result = _categoryManager.GetList();
            return View(result);
        }
    }
}
