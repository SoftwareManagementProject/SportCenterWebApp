using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfCartRepository : EfEntityRepositoryBase<Cart, Context>, ICartDal
    {
        public Cart GetByMemberUsername(string username)
        {
            using(Context context = new Context())
            {
                return (from m in context.Members
                        join c in context.Carts
                        on m.MemberId equals c.MemberId
                        where m.MemberUserName == username
                        select c
                        ).First();
            };
        }
    }
}
