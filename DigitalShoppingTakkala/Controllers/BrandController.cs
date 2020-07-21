using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShoppingTakkala.Data;
using DigitalShoppingTakkala.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShoppingTakkala.Controllers
{
    public class BrandController : Controller
    {
        private MyContext _ctx;

        public BrandController()
        {
        }

        public BrandController(MyContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult List()
        {
            var brands = new List<Brand>
            {
                new Brand {BrandId=24,BrandName="Hitachi"},
                new Brand {BrandId=25,BrandName="Philips"}

            };
            return View(brands);
        }
    }
}