using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cart : IEntity
    {
        public int CartId { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
