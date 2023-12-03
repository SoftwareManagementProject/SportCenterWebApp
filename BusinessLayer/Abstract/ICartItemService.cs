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
        CartItem GetByCartId(int id);
        List<CartItem> GetAllByMemberUsername(string username);
        bool CheckIfPacketNotExistBefore(int packetId, int cartId);
    }
}
