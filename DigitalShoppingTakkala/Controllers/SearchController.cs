using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShoppingTakkala.Data;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShoppingTakkala.Controllers
{
   
    public class SearchController : Controller
    {
        private MyContext _ctx;

        public SearchController(MyContext ctx)
        {
            _ctx = ctx;
        }

        [HttpPost]
        public IActionResult search(string searchitem)
        {
            var model = _ctx.Products.Where(x => (x.ProductName.Contains(searchitem)) || (x.TotalDescription.Contains(searchitem))).ToList();
            return View(model);
        }
    }
}