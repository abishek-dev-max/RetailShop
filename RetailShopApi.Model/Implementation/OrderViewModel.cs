using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailShop.Repository.Entities;


namespace RetailShopApi.Model.Implementation
{
    public class OrderViewModel
    {
        Product _product;
        public Product ProductDetail { get { return _product; } set { _product = value; } }
        
    }
}
