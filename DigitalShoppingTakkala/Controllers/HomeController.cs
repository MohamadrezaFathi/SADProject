using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalShoppingTakkala.Models;
using DigitalShoppingTakkala.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitalShoppingTakkala.Controllers
{
   
    public class HomeController : Controller
    {

        private MyContext _ctx;

        public HomeController(MyContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            return View(_ctx.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
