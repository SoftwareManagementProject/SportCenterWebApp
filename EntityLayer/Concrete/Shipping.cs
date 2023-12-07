using CoreLayer.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Shipping : IEntity
    {
        public int ShippingId { get; set; }
        public string FullName { get; set; }  
        public string Email { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public List<Order> Orders { get; set; }


    }
}
