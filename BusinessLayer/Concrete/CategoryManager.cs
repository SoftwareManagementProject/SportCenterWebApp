using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private  ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal category) 
        {
            _categoryDal= category;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetAllWithDescriptionAndImage()
        {
            return _categoryDal.GetAllWithDescriptionAndImage();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(i => i.CategoryId == id);
        }

        public Category GetByName(string name)
        {
            return _categoryDal.Get(i => i.CategoryName == name);
        }

        public Category GetWithDescriptionAndImageById(int id)
        {
            return _categoryDal.GetWithDescriptionAndImageById(id);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
