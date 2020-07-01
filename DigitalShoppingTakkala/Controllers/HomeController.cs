using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalShoppingTakkala.Models;
using DigitalShoppingTakkala.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZarinpalSandbox;

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

        public IActionResult OnlinePayment(int id)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"].ToString();
                var order = _ctx.Orders.Find(id);
                var d = (int)order.Sum;
                var payment = new Payment(d);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    order.IsFinally = true;
                    _ctx.Orders.Update(order);
                    _ctx.SaveChanges();
                    ViewBag.code = res.RefId;
                    return View();
                }

            }

            return NotFound();
        }
    
    }
}
