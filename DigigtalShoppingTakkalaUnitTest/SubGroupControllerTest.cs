using DigitalShoppingTakkala.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;


namespace DigigtalShoppingTakkalaUnitTest
{
   public class SubGroupControllerTest
    {

    [Fact]
        public void verifySubgroupCount()
        {
            var c = new SubGroupController();
            var result = Assert.IsType<Microsoft.AspNetCore.Mvc.ViewResult>(c.List());
            var model = Assert.IsType<List<DigitalShoppingTakkala.Models.SubGroup>>(result.Model);
            Assert.Equal(3, model.Count());
        }

    }
}
