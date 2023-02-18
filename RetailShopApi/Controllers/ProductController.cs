using Microsoft.AspNetCore.Mvc;
using RetailShopApi.Model.Implementation;
using RetailShopApi.Service.Implementation;
using RetailShopApi.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProductDetails());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_productService.GetByID(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post(ProductViewModel productViewModel)
        {
            _productService.PostProduct(productViewModel);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, ProductViewModel productViewModel)
        {
            _productService.UpdateProduct(id, productViewModel);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _productService.DeleteProduct(id);
        }
        //private readonly ProductService _productService;
        //public ProductController(ProductService productService)
        //{
        //    _productService = productService;
        //}
        //// GET: api/<ValuesController>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_productService.GetProductDetails());
        //}

        //// GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public IActionResult Get(Guid id)
        //{
        //    return Ok(_productService.GetByID(id));
        //}

        //// POST api/<ValuesController>
        //[HttpPost]
        //public void Post(ProductViewModel product)
        //{
        //    _productService.PostProduct(product);
        //}

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(Guid id, ProductViewModel product)
        //{
        //    _productService.UpdateProduct(id, product);
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(Guid id)
        //{
        //    _productService.DeleteProduct(id);
        //}
    }
}
