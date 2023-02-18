using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RetailShop.Repository.Entities;
using RetailShopApi.Model.Implementation;

namespace RetailShopApi.Service.Implementation
{
  public class ProductandOrderMapper : Profile
    {
        public ProductandOrderMapper() 
        {
            CreateMap<Product,ProductViewModel>().ReverseMap();
            CreateMap<Order,OrderViewModel>().ReverseMap();
        }
    }
}
