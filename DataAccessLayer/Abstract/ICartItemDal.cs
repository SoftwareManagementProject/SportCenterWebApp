﻿using CoreLayer.DataAccess;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICartItemDal : IEntityRepositoryBase<CartItem>
    {
        List<CartItem> GetAllByMemberUsername(string username);
    }
}
