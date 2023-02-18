using RetailShopApi.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApi.Service.Interface
{
    public interface IProductService
    {
        List<ProductViewModel> GetProductDetails();
        ProductViewModel GetByID(Guid id);
        void PostProduct(ProductViewModel product);
        void UpdateProduct(Guid id, ProductViewModel product);
        void DeleteProduct(Guid id);
    }
}

