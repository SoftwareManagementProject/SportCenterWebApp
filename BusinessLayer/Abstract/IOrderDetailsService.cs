using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderDetailsService
    {
        void Add(OrderDetails orderDetails);
        void Update(OrderDetails orderDetails);
        void Delete(OrderDetails orderDetails);
        List<OrderDetails> GetAll();
        OrderDetails GetById(int id);
    }
}
