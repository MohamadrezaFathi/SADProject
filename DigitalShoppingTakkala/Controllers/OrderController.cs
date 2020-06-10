using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DigitalShoppingTakkala.Data;
using DigitalShoppingTakkala.Models;
using DigitalShoppingTakkala.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShoppingTakkala.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private MyContext _ctx;
        public OrderController(MyContext ctx)
        {
            _ctx = ctx;
        }



        public IActionResult AddtoCard(int id)
        {
            string CurrentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = _ctx.Orders.SingleOrDefault(o => o.UserId == CurrentUserID && !o.IsFinally);
            if (order == null)
            {
                order = new Order()
                {
                    UserId = CurrentUserID,
                    CreateDate = DateTime.Now,
                    IsFinally = false,
                    Sum = 0,


                };
                _ctx.Orders.Add(order);
                _ctx.OrderDetails.Add(new OrderDetail()
                {
                    OrderId = order.OrderId,
                    Count = 1,
                    FinalPrice = _ctx.Products.Find(id).Price2,
                    ProductId = id

                });
                _ctx.SaveChanges();
            }
            else
            {

                var details = _ctx.OrderDetails.SingleOrDefault(d => d.OrderId == order.OrderId && d.ProductId == id);
                if (details == null)
                {
                    _ctx.OrderDetails.Add(new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        FinalPrice = _ctx.Products.Find(id).Price2,
                        ProductId = id

                    });
                }
                else
                {
                    details.Count += 1;
                    _ctx.Update(details);
                }

                _ctx.SaveChanges();
            }
            UpdateSumOrder(order.OrderId);
            return Redirect("/");
        }
        public void UpdateSumOrder(int orderId)
        {
            var order = _ctx.Orders.Find(orderId);
            order.Sum = _ctx.OrderDetails.Where(o => o.OrderId == order.OrderId).Select(d => d.Count * d.FinalPrice).Sum();
            _ctx.Update(order);
            _ctx.SaveChanges();
        }
        public IActionResult ShowOrder()
        {
            string CurrentUserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = _ctx.Orders.SingleOrDefault(o => o.UserId == CurrentUserID && !o.IsFinally);
            List<ShowOrderViewModel> _list = new List<ShowOrderViewModel>();
            if (order != null)
            {
                var details = _ctx.OrderDetails.Where(d => d.OrderId == order.OrderId).ToList();
                foreach (var item in details)
                {
                    var product = _ctx.Products.Find(item.ProductId);
                    _list.Add(new ShowOrderViewModel()
                    {
                        Count = item.Count,
                        ImageName = product.ImageName,
                        OrderDetailId = item.OrderDetailId,
                        ProductName = product.ProductName,
                        Price = item.FinalPrice,
                        Sum = item.Count * item.FinalPrice

                    });

                }
            }

            return View(_list);

        }
        public IActionResult Delete(int id)
        {
            var orderdetail = _ctx.OrderDetails.Find(id);
            _ctx.Remove(orderdetail);
            _ctx.SaveChanges();
            return RedirectToAction("ShowOrder");
        }
        public IActionResult Editing(int id,int ud)
        {
            var orderdetail = _ctx.OrderDetails.Find(id);
            if (ud == 1)
            {
                orderdetail.Count += 1;
                _ctx.Update(orderdetail);
            }
            else if(ud==2)
            {
                orderdetail.Count -= 1;
                if (orderdetail.Count == 0)
                {
                    _ctx.OrderDetails.Remove(orderdetail);
                   
                }
                else { _ctx.Update(orderdetail); }
                
            }
            
            _ctx.SaveChanges();
            return RedirectToAction("ShowOrder");
        }


    }
}