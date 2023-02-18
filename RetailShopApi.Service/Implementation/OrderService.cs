using AutoMapper;
using RetailShop.Repository.Entities;
using RetailShop.Repository.Implementation;
using RetailShop.Repository.Interface;
using RetailShopApi.Model.Implementation;
using RetailShopApi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApi.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public List<OrderViewModel> GetOrderDetails()
        {
            var OrderList = _orderRepository.GetOrder();
            List<OrderViewModel> OrderViewModelList = _mapper.Map<List<OrderViewModel>>(OrderList);
            return OrderViewModelList;
        }
        public OrderViewModel GetByID(Guid id)
        {
            var Order = _orderRepository.GetOrder(id);
            OrderViewModel OrderViewModel = _mapper.Map<OrderViewModel>(Order);
            return OrderViewModel;
        }

        public void PostOrder(OrderViewModel order)
        {
            var OrderNew = _mapper.Map<Order>(order);
            OrderNew.Id = Guid.NewGuid();
            _orderRepository.PostOrder(OrderNew);
        }

        public void PutOrder(Guid id, OrderViewModel order)
        {
            var OrderNew = _mapper.Map<Order>(order);
            OrderNew.Id = id;
            _orderRepository.UpdateOrder(OrderNew);
        }
        public void DeleteOrder(Guid id)
        {
            _orderRepository.DeleteOrder(id);
        }
    }
}
