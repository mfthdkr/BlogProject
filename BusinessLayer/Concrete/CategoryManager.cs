using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using DataAccessLayer.Concrete.EntityFramework;

namespace BusinessLayer.Concrete
{
    public class CategoryManager: ICategoryService
    {
        private readonly EfCategoryRepository _efCategoryRepository;

        public CategoryManager()
        {
            _efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _efCategoryRepository.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            _efCategoryRepository.Update(category);

        }

        public List<Category> GetList()
        {
            return _efCategoryRepository.GetListAll();
        }

        public Category GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }
    }
}
