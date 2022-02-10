﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ContosoPets2.Models
{
    [Index(nameof(CustomerId), Name = "IX_Orders_CustomerId")]
    public partial class Order
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        [Key]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFilfilled { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; } = null!;
        [InverseProperty(nameof(ProductOrder.Order))]
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
