using DigitalShoppingTakkala.Data;
using DigitalShoppingTakkala.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DigitalShoppingTakkala.Components
{
    public class CardComponent: ViewComponent
    {
        private MyContext _ctx;
        public CardComponent(MyContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<ShowCardViewModel> _list = new List<ShowCardViewModel>();
            if (User.Identity.IsAuthenticated)
            {
                string CurrentUserID = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var order = _ctx.Orders.SingleOrDefault(o => o.UserId == CurrentUserID && !o.IsFinally);

                if (order != null)
                {
                    var details = _ctx.OrderDetails.Where(d => d.OrderId == order.OrderId).ToList();
                    foreach(var item in details)
                    {
                        var product = _ctx.Products.Find(item.ProductId);
                        _list.Add(new ShowCardViewModel()
                        {
                            Count = item.Count
                        });
                    }
                }
            }
            return View("/Views/Shared/_ShowCard.cshtml", _list);
        }
    }
}
