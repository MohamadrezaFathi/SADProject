using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalShoppingTakkala.Data;
using DigitalShoppingTakkala.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalShoppingTakkala.Controllers
{
    public class SubGroupController : Controller
    {
        private MyContext _ctx;

        public SubGroupController()
        {
        }

        public SubGroupController(MyContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult List()
        {
            var subgroup = new List<SubGroup>
            {
                new SubGroup {SubGroupId=15,SubGroupName="SmartWatch",GroupId=1},
                new SubGroup {SubGroupId=16,SubGroupName="gear",GroupId=1},
                new SubGroup {SubGroupId=17,SubGroupName="keyboard",GroupId=2}
            };
            return View(subgroup);
        }
    }
}