using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repositories.Generic;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogRepository: GenericRepository<Blog>,IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using BlogContext blogContext = new BlogContext();
            return blogContext.Blogs.Include(x => x.Category).ToList();
        }
    }
}
