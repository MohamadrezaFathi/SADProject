using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(400)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(1000)]
        public string TotalDescription { get; set; }
        [Required]
        public double Price { get; set; }
        public double Price2 { get; set; }
        public int introduceyear { get; set; }
        public int mass { get; set; }
        public string size { get; set; }
        [Required]
        public string Colors { get; set; }
        [Required]
        public int SubGroupId { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
        public int status { get; set; }
        [Required]
        public int BrandId { get; set; }



        public SubGroup SubGroup { get; set; }
        public Brand Brand { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
