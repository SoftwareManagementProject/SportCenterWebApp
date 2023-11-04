using CoreLayer.DataAccess.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InMemory
{
    public class InMemoryCategoryRepository : ICategoryDal
    {
        private IQueryable<Category> _categories;
        public InMemoryCategoryRepository()
        {
            _categories = new List<Category>
                {
                    new Category(){CategoryId=1, CategoryName="Fitness", CategoryInfo="üiğiüğğşğşsğaüğ"},
                    new Category(){CategoryId=2, CategoryName="Kickbox", CategoryInfo="üiğiüğğşğşsğaüğ"},
                    new Category(){CategoryId=3, CategoryName="Zumba",  CategoryInfo="üiğiüğğşğşsğaüğ"},
                    new Category(){CategoryId=4, CategoryName="Pilates",  CategoryInfo="üiğiüğğşğşsğaüğ"},
                    new Category(){CategoryId=5, CategoryName="Coaching",  CategoryInfo="üiğiüğğşğşsğaüğ"},

                }.AsQueryable();
        }

        public void Add(Category entity)
        {
            _categories.ToList().Add(entity);
        }

        public void Delete(Category entity)
        {
            _categories.ToList().Remove(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllWithDescriptionAndImage()
        {
            throw new NotImplementedException();
        }

        public Category GetWithDescriptionAndImageById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            
            var category = _categories.ToList().Find(i=> i.CategoryId == entity.CategoryId);
            category.CategoryInfo = entity.CategoryInfo;
            category.CategoryPrice = entity.CategoryPrice;
            category.CategoryName = entity.CategoryName;


        }
    }
}
