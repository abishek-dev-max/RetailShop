using Microsoft.IdentityModel.Tokens;
using RetailShop.Repository.Entities;
using RetailShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Implementation
{
   public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Order> GetOrder()
        {
            var OrderList = _dbContext.Orders.ToList();
            return OrderList;
        }

        public Order GetOrder(Guid id)
        {
            var Order = _dbContext.Orders.FirstOrDefault(x => x.Id == id);
            return Order;
        }

        public void PostOrder(Order Order)
        {
            
            _dbContext.Orders.Add(Order);
            _dbContext.SaveChanges();
        }

        public void DeleteOrder(Guid id)
        {
            var Order = _dbContext.Orders.FirstOrDefault(y => y.Id == id);
            _dbContext.Orders.Remove(Order);
            _dbContext.SaveChanges();
        }

        public void UpdateOrder(Order Order)
        {
            _dbContext.Orders.Update(Order);
            _dbContext.SaveChanges();
        }
    }
}
