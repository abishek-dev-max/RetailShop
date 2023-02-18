using RetailShopApi.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApi.Service.Interface
{
    public interface IOrderService
    {
        List<OrderViewModel> GetOrderDetails();
        OrderViewModel GetByID(Guid id);
        void PostOrder(OrderViewModel order);
        void PutOrder(Guid id, OrderViewModel order);
        void DeleteOrder(Guid id);
    }
}
