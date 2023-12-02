using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartService
    {
        void Add(Cart cart);
        void Update(Cart cart);
        void Delete(Cart cart);
        List<Cart> GetAll();
        Cart GetById(int id);

    }
}
