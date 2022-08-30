using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var result = _blogManager.GetBlogListWithCategory();
            return View(result);
        }

        public IActionResult BlogReadAll(int blogId)
        {   
            ViewBag.BlogId= blogId;
            var result = _blogManager.GetBlogById(blogId);
            return View(result);
        }
    }
}
