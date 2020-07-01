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
        [Required(ErrorMessage ="وارد کردن نام الزامی است")]
        public string nameofcr { get; set; }
        [Required(ErrorMessage = "وارد کردن نام خانوادگی الزامی است")]
        public string lastnameofcr { get; set; }
        [Required(ErrorMessage = "وارد کردن آدرس الزامی است")]
        public string addressofcr { get; set; }
        [Required(ErrorMessage = "وارد کردن تلفن همراه الزامی است")]
        public string phoneofcr { get; set; }
    }
}
