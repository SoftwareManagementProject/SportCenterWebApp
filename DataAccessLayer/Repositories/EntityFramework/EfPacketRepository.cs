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
    public class EfPacketRepository : EfEntityRepositoryBase<Packet, Context>, IPacketDal
    {
        public List<Packet> GetAllByUsername(string username)
        {
            using(Context c = new Context())
            {
                var packets = (from s in c.Shippings
                                from o in s.Orders
                                from od in o.OrderDetails
                                where s.Username == username
                                select od.Packet
                                ).ToList();

                return packets;
            };
        }
    }
}
