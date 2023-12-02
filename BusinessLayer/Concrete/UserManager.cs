using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(AppUser user)
        {
            _userDal.Add(user);
        }

        public void Delete(AppUser user)
        {
            _userDal.Delete(user);
        }

        public List<AppUser> GetAll()
        {
            return _userDal.GetAll();
        }

        public AppUser GetById(int id)
        {
            return _userDal.Get(i => i.Id == id);
        }

        public AppUser GetByUsername(string username)
        {
            return _userDal.Get(i => i.UserName == username);
        }

        public void Update(AppUser user)
        {
            _userDal.Update(user);
        }
    }
}
