using DigitalShoppingTakkala.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DigigtalShoppingTakkalaUnitTest
{
    public class BrandControllerTest
    {

        [Fact]
        public void verifyBrandCount()
        {
            var c = new BrandController();
            var result = Assert.IsType<Microsoft.AspNetCore.Mvc.ViewResult>(c.List());
            var model = Assert.IsType<List<DigitalShoppingTakkala.Models.Brand>>(result.Model);
            Assert.Equal(2, model.Count());
        }

    }
}
