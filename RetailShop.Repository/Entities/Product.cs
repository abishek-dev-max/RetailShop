
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Entities
{
  public class Product 
    {
        [Key]
        public Guid? Id { get; set; }= Guid.NewGuid();
        public string? Name { get; set; }=string.Empty;
        public int? Price { get; set; } = int.MaxValue;
        public int? Quantity { get; set; }=int.MaxValue;
        public string? Category { get; set; } = string.Empty;
    }
}
