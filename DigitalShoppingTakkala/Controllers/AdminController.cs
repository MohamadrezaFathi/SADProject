using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShoppingTakkala.Data;
using DigitalShoppingTakkala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DigitalShoppingTakkala.Controllers
{
    public class AdminController : Controller
    {
      
        private MyContext _ctx;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AdminController(MyContext ctx,IHostingEnvironment hostEnvironment )
            {
                _ctx = ctx;
            _hostingEnvironment = hostEnvironment;
        }

        public AdminController()
        {
        }

        public IActionResult Index()
        {
            var information = _ctx.Products.ToList();
            return View(information);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct([Bind("ProductId", "ProductName", "TotalDescription", "Price", "Price2", "introduceyear", "mass", "size", "instock", "Colors", "SubGroupId", "UploadImage", "status", "BrandId")] Product product)
        {
            if (ModelState.IsValid) {
                string wwwRootPath = _hostingEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(product.UploadImage.FileName);
                string extension = Path.GetExtension(product.UploadImage.FileName);
                product.ImageName = filename = filename + extension;
                string path = Path.Combine(wwwRootPath + "/Images/", filename);

                using(var filestream=new FileStream(path, FileMode.Create))
                {
                    product.UploadImage.CopyTo(filestream);
                }
                _ctx.Add(product);
                _ctx.SaveChanges();
                return RedirectToAction("Index");

                    }
          
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var item = _ctx.Products.Where(x => x.ProductId == id).SingleOrDefault();
            _ctx.Products.Remove(item);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBrand([Bind("BrandId", "BrandName")]Brand brand)

        {
            _ctx.Add(brand);
            _ctx.SaveChanges();
            return RedirectToAction("index");
        }


    }
}