using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string CommentText { get; set; }
        public int Score { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
