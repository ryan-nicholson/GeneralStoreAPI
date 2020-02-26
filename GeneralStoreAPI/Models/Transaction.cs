using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Product))] // connects with Project and already does with ProductId because its above it
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))] // connects to Customer because it's above it, passes CustomerId to connect with above
        public virtual Customer Customer { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public double TotalCost
        {
            get
            {
                return Product.Price * ProductCount;
            }
        }
        public int ProductCount { get; set; }
    }
}