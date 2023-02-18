using RetailShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Interface
{
    public interface IProductRepository
    {
        public List<Product> GetProduct();
        public Product GetProductById(Guid id);
        public void PostProduct(Product product);
        public void DeleteProduct(Guid id);
        public void UpdateProduct(Product product);

    }
}
