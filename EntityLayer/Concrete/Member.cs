using CoreLayer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Member : IEntity
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberNameSurname { get; set; }
        public string MemberUserName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPassword { get; set; }
        public bool MemberStatus { get; set; }
        public List<MemberCategory>? Categories { get; set; }
        public List<MemberTrainer>? Trainers { get; set; }
    }
}
