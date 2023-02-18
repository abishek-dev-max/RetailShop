using RetailShopApi.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Mstest
{
    public class SampleProduct
    {
        public ProductViewModel GetProductByName(string productName)
        {
            List<ProductViewModel> products = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Name= "apple",
                    Category="Electronics",
                    Price=134123,
                    Quantity=2
                }
            };
            ProductViewModel product = products.FirstOrDefault(x=>x.Name == productName);
            return product;

        }
    }
}
