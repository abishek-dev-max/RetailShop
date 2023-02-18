
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApi.Model.Implementation
{
    public class ProductViewModel
    {
        string _Name;
        int _Quantity;
        string _Category;
        int _Price;

        public string Name { get { return _Name; } set { _Name = value; } }
        public int Price { get { return _Price; } set { _Price = value; } }
        public int Quantity { get { return _Quantity; } set { _Quantity = value; } }
        public string Category { get { return _Category; } set { _Category = value; } }

    }
}
