using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderDetails : IEntity
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int PacketId { get; set; }
        public Order Order { get; set; }
        public Packet Packet { get; set; }

    }
}
