using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DescriptionManager : IDescriptionService
    {
        private IDescriptionDal _descriptionDal;
        public DescriptionManager(IDescriptionDal descriptionDal) 
        {
            _descriptionDal= descriptionDal;
        }
        public void Add(Description description)
        {
            _descriptionDal.Add(description);
        }

        public void Delete(Description description)
        {
            _descriptionDal.Delete(description);
        }

        public List<Description> GetAll(Expression<Func<Description, bool>> filter)
        {
            return _descriptionDal.GetAll(filter);
        }

        public List<Description> GetAll()
        {
            return _descriptionDal.GetAll();
        }

        public Description GetById(int id)
        {
            return _descriptionDal.Get(i => i.DescriptionId == id);
        }

        public void Update(Description description)
        {
            _descriptionDal.Update(description);
        }
    }
}
