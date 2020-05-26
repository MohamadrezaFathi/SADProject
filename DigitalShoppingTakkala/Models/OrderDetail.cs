using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public double FinalPrice { get; set; }
        [Required]
        public int Count { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
