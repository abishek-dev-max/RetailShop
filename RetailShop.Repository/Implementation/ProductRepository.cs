using RetailShop.Repository.Entities;
using RetailShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Implementation
{
   public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetProduct()
        {
            var ProductList = _dbContext.Products.ToList();
            return ProductList;
        }

        public Product GetProductById(Guid id)
        {
            var Product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            return Product!;
        }

        public void PostProduct(Product product)
        {

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(Guid id)
        {
            var Product = _dbContext.Products.FirstOrDefault(y => y.Id == id);
            _dbContext.Products.Remove(entity: Product!);
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product Product)
        {

            _dbContext.Products.Update(Product);
            _dbContext.SaveChanges();
        }
    }
}
