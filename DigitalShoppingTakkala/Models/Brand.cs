using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        [MaxLength(200)]
        public string BrandName { get; set; }


        public List<Product> Products { get; set; }
    }
}
