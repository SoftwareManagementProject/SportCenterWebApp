using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IShippingService
    {
        void Add(Shipping shipping);
        void Delete(Shipping shipping);
        void Update(Shipping shipping);
        List<Shipping> GetAll();
        Shipping GetById(int id);

    }
}
