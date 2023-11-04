using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MemberTrainer
    {
        public int MemberId { get; set; }
        public int TrainerId { get; set; }
        public Member Member { get; set; }
        public Trainer Trainer { get; set; }

    }
}
