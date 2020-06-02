using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShoppingTakkala.Data;

using Microsoft.AspNetCore.Mvc;

namespace DigitalShoppingTakkala.Controllers
{
    public class ProductController : Controller
    {
        private MyContext _ctx;

        public ProductController(MyContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult GetAllBySGID(int id)
        {
           
            return View(_ctx.Products.Where(p=>p.SubGroupId == id).ToList());
        }

        public IActionResult GetProductByid(int id)
        {
            
            return View(_ctx.Products.Find(id));
        }
    }
}