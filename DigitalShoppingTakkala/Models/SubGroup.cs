using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class SubGroup
    {
        [Key]
        public int SubGroupId { get; set; }
        [Required]
        [MaxLength(300)]
        public string SubGroupName { get; set; }
        public int GroupId { get; set; }


        public Group Group { get; set; }
        public List<Product> products { get; set; }
    }
}
