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
      Order newOrder = new Order("Title", "description", 500, "Sept 29");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitleOfOrder_String()
    {
      // Arrange
      string expectedTitle = "Order Title";
      Order newOrder = new Order(expectedTitle, "description", 500, "Sept 29");
      //Act 
      string testTitle = newOrder.Title;
      //Assert
      Assert.AreEqual(testTitle, expectedTitle);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsDescriptionOfOrder_String()
    {
      // Arrange
      string expectedDescription = "Some description probably";
      Order newOrder = new Order("Title", expectedDescription, 500, "Sept 29");
      //Act 
      string testDescription = newOrder.Description;
      //Assert
      Assert.AreEqual(testDescription, expectedDescription);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsPriceOfOrder_Decimal()
    {
      // Arrange
      decimal expectedPrice = 5000;
      Order newOrder = new Order("Title", "description", expectedPrice, "Sept 29");
      //Act 
      decimal testPrice = newOrder.Price;
      //Assert
      Assert.AreEqual(testPrice, expectedPrice);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsDateOfOrder_String()
    {
      // Arrange
      string expectedDate = "10/01/2023";
      Order newOrder = new Order("Title", "description", 500, expectedDate);
      //Act 
      string testDate = newOrder.Date;
      //Assert
      Assert.AreEqual(testDate, expectedDate);
    }

    [TestMethod]
    public void GetAllOrders_ReturnOrders_OrderList()
    {
      // Arrange
      string title1 = "Cool Title";
      string title2 = "Another Title but Cooler";
      Order newOrder1 = new Order(title1, "description1", 12, "Sept 30");
      Order newOrder2 = new Order(title2, "description2", 14, "Sept 28");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      //Act 
      List<Order> expectedList = Order.GetAllOrders();
      //Assert
      CollectionAssert.AreEqual(newList, expectedList);

    }
  }
}