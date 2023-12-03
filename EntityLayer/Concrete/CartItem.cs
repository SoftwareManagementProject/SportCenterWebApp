using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CartItem : IEntity
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int PacketId { get; set; }
        public Packet Packet { get; set; }
        public Cart Cart { get; set; }

    }
}
