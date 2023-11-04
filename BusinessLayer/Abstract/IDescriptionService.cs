using CoreLayer.DataAccess.Entities;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDescriptionService
    {
        void Add(Description description);
        void Update(Description description);
        void Delete(Description description);
        List<Description> GetAll();
        List<Description> GetAll(Expression<Func<Description, bool>> filter);
        Description GetById(int id);
    }
}
