using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int ShippingId { get; set; }
        public DateTime OrderDate { get; set; }
        public Shipping Shipping { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
