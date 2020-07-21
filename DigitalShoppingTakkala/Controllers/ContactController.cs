using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShoppingTakkala.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult CustomerServices()
        {
            return View();
        }

        public IActionResult CustomerQuestions()
        {
            return View();
        }
        public IActionResult Offers()
        {
            return View();
        }

    }
}