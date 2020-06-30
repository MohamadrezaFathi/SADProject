using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class Delivery
    {
        [Required]
        public string DeliveryID { get; set; }
        public string Deliveryname { get; set; }
    }
}
