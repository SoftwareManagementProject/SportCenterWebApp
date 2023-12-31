﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Entities;

namespace EntityLayer.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryInfo { get; set; }
        public double CategoryPrice { get; set; }
        public List<MemberCategory>? Members { get; set; }
        public List<PacketCategory>? Packets { get; set; }
        public  ICollection<Description>? Descriptions { get; set; }
        public  ICollection<Image>? Images { get; set; }
        public  ICollection<Trainer>? Trainers { get; set; }
    }
}
