using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaper.Controllers;
using RockPaper.Models;

namespace RockPaper.Tests
{
  [TestClass]
  public class HomeControllerTest
  {

    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
