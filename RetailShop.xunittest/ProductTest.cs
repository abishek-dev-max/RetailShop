using Moq;
using RetailShopApi.Controllers;
using RetailShopApi.Model.Implementation;
using RetailShopApi.Service.Implementation;
using RetailShopApi.Service.Interface;

namespace RetailShop.xunittest
{
    public class ProductTest
    {
        private readonly Mock<IProductService> _productService;
        public ProductTest()
        {
            _productService = new Mock<IProductService>();
        }
        [Fact]
        public void GetAllProduct()
        {
            var testData = GetProductViewModels();
            var lookups = _productService.Setup(x => x.GetProductDetails()).Returns(testData);
            var productController = new ProductController(_productService.Object);
            var response = productController.Get();
            Assert.NotNull(response);
        }
        private List<ProductViewModel> GetProductViewModels()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Name = "apple",
                    Price = 30000,
                    Quantity =1,
                    Category="electronics"
                }
            };
        }
    }
}