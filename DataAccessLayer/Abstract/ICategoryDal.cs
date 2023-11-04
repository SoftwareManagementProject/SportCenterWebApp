using CoreLayer.DataAccess;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IEntityRepositoryBase<Category>
    {
        List<Category> GetAllWithDescriptionAndImage();
        Category GetWithDescriptionAndImageById(int id);
        List<Category> GetAllByMember(int memberId);
    }
}
