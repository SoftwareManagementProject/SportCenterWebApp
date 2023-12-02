using CoreLayer.DataAccess.EntityFramework;
using CoreLayer.Entities.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfUserRepository : EfEntityRepositoryBase<AppUser, Context>, IUserDal
    {
    }
}
