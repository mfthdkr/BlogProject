using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract.Generic;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories.Generic
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T t)
        {
            using var blogContext = new BlogContext();
            blogContext.Add(t);
            blogContext.SaveChanges();
        }

        public void Delete(T t)
        {
            using var blogContext = new BlogContext();
            blogContext.Remove(t);
            blogContext.SaveChanges();
        }

        public void Update(T t)
        {
            using var blogContext = new BlogContext();
            blogContext.Update(t);
            blogContext.SaveChanges();
        }

        public List<T> GetListAll()
        {
            using var blogContext = new BlogContext();
            return blogContext.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            using var blogContext = new BlogContext();
            return blogContext.Set<T>().Find(id);
        }
    }
}
