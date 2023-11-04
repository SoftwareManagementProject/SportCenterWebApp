using CoreLayer.DataAccess.Entities;
using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category, Context>, ICategoryDal
    {
        public List<Category> GetAllByMember(int memberId)
        {
            using (Context context = new Context())
            {
                return context.MemberCategories.Where(x => x.MemberId == memberId).Select(i => i.Category).ToList();

            }
        }

        public List<Category> GetAllWithDescriptionAndImage()
        {
            using (Context context = new Context())
            {
                return context.Categories.Include(x => x.Descriptions).Include(i => i.Images).ToList();
                
            }
        }


        public Category GetWithDescriptionAndImageById(int id)
        {
            using (Context context = new Context())
            {
                return context.Categories.Where(i => i.CategoryId == id)
                    .Include(x => x.Descriptions).Include(i => i.Images).FirstOrDefault()!;

            }
        }
    }
}
