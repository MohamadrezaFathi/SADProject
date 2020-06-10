using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Models.ViewModels
{
    public class ShowOrderViewModel
    {
        public int OrderDetailId { get; set; }
        public string ProductName { get; set; }
        public string ImageName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double Sum { get; set; }

    }
}
