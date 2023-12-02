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
    public class CartItemManager : ICartItemService
    {
        private ICartItemDal _cartItemDal;

        public CartItemManager(ICartItemDal cartItemDal)
        {
            _cartItemDal = cartItemDal;
        }

        public void Add(CartItem cartItem)
        {
            _cartItemDal.Add(cartItem);
        }

        public void Delete(CartItem cartItem)
        {
            _cartItemDal.Delete(cartItem);

        }

        public List<CartItem> GetAll()
        {
            return _cartItemDal.GetAll();
        }

        public CartItem GetById(int id)
        {
            return _cartItemDal.Get(i => i.CartItemId == id);

        }

        public void Update(CartItem cartItem)
        {
            _cartItemDal.Update(cartItem);

        }
    }
}
