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
        public IActionResult GetAllBySGID(int id, string sorting)
        {
            var products = _ctx.Products.Where(p => p.SubGroupId == id).ToList();
            products = products.OrderBy(x => x.Price2).ToList();

            if (!string.IsNullOrEmpty(sorting))
            {
                if (sorting == "1")
                {
                    products = products.OrderBy(x => x.status).ToList();
                }
                if (sorting == "2")
                {
                    products = products.OrderByDescending(x => x.status).ToList();
                }

                if (sorting == "5")
                {
                    products = products.OrderBy(x => x.Price2).ToList();
                }
                if (sorting == "4")
                {
                    products = products.OrderByDescending(x => x.Price2).ToList();
                }
            }

            else
            {
                products = products.OrderBy(x => x.ProductId).ToList();
            }

            return View(products);
        }

        public IActionResult GetProductByid(int id)
        {

            return View(_ctx.Products.Find(id));
        }
    }
}