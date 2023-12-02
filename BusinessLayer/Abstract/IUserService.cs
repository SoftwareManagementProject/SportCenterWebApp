using CoreLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void Add(AppUser user);
        void Update(AppUser user);
        void Delete(AppUser user);
        AppUser GetById(int id);
        List<AppUser> GetAll(); 
        AppUser GetByUsername(string username);
    }
}
