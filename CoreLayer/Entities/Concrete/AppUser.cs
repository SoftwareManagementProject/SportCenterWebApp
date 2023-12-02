using CoreLayer.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public string FullName { get; set; }
    }
}
