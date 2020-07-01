using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class ClientReceiver
    {
        [Key]
        public int CRid { get; set; }
        [Required]
        public string CRuser { get; set; }
        [Required]
        public string nameofcr { get; set; }
        [Required]
        public string lastnameofcr { get; set; }
        [Required]
        public string addressofcr { get; set; }
        [Required]
        public string phoneofcr { get; set; }
    }
}
