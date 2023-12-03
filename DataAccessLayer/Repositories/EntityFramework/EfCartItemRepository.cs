using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfCartItemRepository : EfEntityRepositoryBase<CartItem, Context>, ICartItemDal
    {
        public List<CartItem> GetAllByMemberUsername(string username)
        {
            using (Context context = new Context())
            {
                return (from ci in context.CartItems
                        join c in context.Carts
                        on ci.CartId equals c.CartId
                        join m in context.Members
                        on c.MemberId equals m.MemberId
                        where m.MemberUserName == username
                        select ci
                        ).Include(i => i.Packet).ToList();
            };
        }
    }
}
