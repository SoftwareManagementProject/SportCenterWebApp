using CoreLayer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactEmail { get; set; }
        public string ContactContent { get; set; }
    }
}
