using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContosoPets2.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [InverseProperty(nameof(ProductOrder.Product))]
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
