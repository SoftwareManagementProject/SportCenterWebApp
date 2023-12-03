using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Packet : IEntity
    {
        public int PacketId { get; set; }
        public string PacketDescription { get; set; }
        public double PacketPrice { get; set; }
        public string PacketType { get; set; }
        public List<PacketCategory>? Categories { get; set; }
        public CartItem? CartItem { get; set; }
    }
}
