using DigitalShoppingTakkala.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DigigtalShoppingTakkalaUnitTest
{
      
    public class HomeControllerTest
    {

        [Fact]
        public void verifyIndexPage()
        {
            //Arange
            var controllers = new AdminController();
            //Act
            var result = controllers.Index();
            //Assert
            Assert.IsType<ViewResult>(result);

        }

       

       

    }
}
