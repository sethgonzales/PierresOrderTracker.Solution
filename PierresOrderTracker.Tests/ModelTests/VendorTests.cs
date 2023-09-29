using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("vendor test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsNameOfVendor_String()
    {
      // Arrange
      string expectedName = "Not a fake vendor";
      Vendor newVendor = new Vendor(expectedName);
      //Act 
      string testName = newVendor.VendorName;
      //Assert
      Assert.AreEqual(testName, expectedName);
    }

  }
} 