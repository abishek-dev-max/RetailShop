using Microsoft.AspNetCore.Mvc;
using RetailShopApi.Model.Implementation;
using RetailShopApi.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.GetOrderDetails());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult GetByID(Guid id)
        {
            return Ok(_orderService.GetByID(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(OrderViewModel OrderViewModel)
        {
            _orderService.PostOrder(OrderViewModel);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, OrderViewModel OrderViewModel)
        {
            _orderService.PutOrder(id, OrderViewModel);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _orderService.DeleteOrder(id);
        }
    }
}
