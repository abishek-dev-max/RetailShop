using RetailShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Interface
{
    public interface IOrderRepository
    {
        public List<Order> GetOrder();
        public Order GetOrder(Guid id);
        public void PostOrder(Order Order);
        public void DeleteOrder(Guid id);
        public void UpdateOrder(Order Order);
    }
}
