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
    public class ShippingManager : IShippingService
    {
        private IShippingDal _shippingDal;
        public ShippingManager(IShippingDal shippingDal)
        {
            _shippingDal= shippingDal;
        }
        public void Add(Shipping shipping)
        {
            _shippingDal.Add(shipping);
        }

        public void Delete(Shipping shipping)
        {
            _shippingDal.Delete(shipping);
        }

        public List<Shipping> GetAll()
        {
            return _shippingDal.GetAll();
        }

        public Shipping GetById(int id)
        {
            return _shippingDal.Get(i => i.ShippingId == id);
        }

        public void Update(Shipping shipping)
        {
            _shippingDal.Update(shipping);
        }
    }
}
