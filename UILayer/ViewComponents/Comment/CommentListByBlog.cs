using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Comment
{
    public class CommentListByBlog: ViewComponent
    {
        readonly CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var result = _commentManager.GetList(id);
            return View(result);
        }
    }
}
