using CoreLayer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Description : IEntity
    {
        [Key]
        public int DescriptionId { get; set; }
        public int CategoryId { get; set; }
        public string DescriptionName { get; set; }
        public Category Category { get; set; }
    }
}
