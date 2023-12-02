using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PacketCategory
    {
        public int PacketId { get; set; }
        public int CategoryId { get; set; }
        public Packet Packet { get; set; }
        public Category Category { get; set; }
    }

}
