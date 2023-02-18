
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Entities
{
   public class Order 
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public Guid ProdutId { get; set; }
        [ForeignKey(nameof(ProdutId))]
        public Product ProductName { get; set; }
    }
}
