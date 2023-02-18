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
   public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductViewModel> GetProductDetails()
        {
            var ProductList = _productRepository.GetProduct();
            var ProductViewModelList=ProductList.Select(x=>_mapper.Map<ProductViewModel>(x)).ToList();
            return ProductViewModelList;
        }
        public ProductViewModel GetByID(Guid id)
        {
            Product Product = _productRepository.GetProductById(id);
            ProductViewModel ProductViewModel = _mapper.Map<ProductViewModel>(Product);
            return ProductViewModel;
        }

        public void PostProduct(ProductViewModel product)
        {
            var ProductNew = _mapper.Map<Product>(product);
            ProductNew.Id = Guid.NewGuid();
            _productRepository.PostProduct(ProductNew);
        }

        public void UpdateProduct(Guid id, ProductViewModel product)
        {
            var ProductNew = _mapper.Map<Product>(product);
            ProductNew.Id = id;
            _productRepository.UpdateProduct(ProductNew);
        }
        public void DeleteProduct(Guid id)
        {
            _productRepository.DeleteProduct(id);
        }


    }
}
