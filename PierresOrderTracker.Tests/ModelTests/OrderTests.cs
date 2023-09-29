using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderTracker.Models;
using System;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Order", "description", 500, "Sept 29");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitleOfOrder_String()
    {
      // Arrange
      string expectedTitle = "Order Title";
      Order newOrder = new Order("Order Title", "description", 500, "Sept 29");
      //Act 
      string testTitle = newOrder.Title;
      //Assert
      Assert.AreEqual(testTitle, expectedTitle);
    }
  }
}