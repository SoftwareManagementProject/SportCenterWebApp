using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Concrete
{
    public class MemberCategory
    {
        public int MemberId { get; set; }
        public int CategoryId { get; set; }
        public Member Member { get; set; }
        public Category Category { get; set; }
    }
}
