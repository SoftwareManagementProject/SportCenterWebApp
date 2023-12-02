using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartItemService
    {
        void Add(CartItem cartItem);
        void Update(CartItem cartItem);
        void Delete(CartItem cartItem);
        List<CartItem> GetAll();
        CartItem GetById(int id);
    }
}
