using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderDetailsManager : IOrderDetailsService
    {
        private IOrderDetailsDal _orderDetailsDal;

        public OrderDetailsManager(IOrderDetailsDal orderDetailsDal)
        {
            _orderDetailsDal = orderDetailsDal;
        }

        public void Add(OrderDetails orderDetails)
        {
            _orderDetailsDal.Add(orderDetails);
        }

        public void Delete(OrderDetails orderDetails)
        {
            _orderDetailsDal.Delete(orderDetails);

        }

        public List<OrderDetails> GetAll()
        {
            return _orderDetailsDal.GetAll();
        }

        public OrderDetails GetById(int id)
        {
            return _orderDetailsDal.Get(i => i.OrderDetailsId == id);
        }

        public void Update(OrderDetails orderDetails)
        {
            _orderDetailsDal.Update(orderDetails);

        }
    }
}
