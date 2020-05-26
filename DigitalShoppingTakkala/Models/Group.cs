using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [Required]
        [MaxLength(300)]
        public string GroupName { get; set; }


        public List<SubGroup> subGroups { get; set; }
    }
}
