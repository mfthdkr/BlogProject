using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository: ICategoryDal
    {
        readonly BlogContext _blogContext= new BlogContext();
        public List<Category> ListAllCategory()
        {
            return _blogContext.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            _blogContext.Add(category);
            _blogContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _blogContext.Remove(category);
            _blogContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _blogContext.Update(category);
            _blogContext.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _blogContext.Categories.Find(id);
        }
    }
}
