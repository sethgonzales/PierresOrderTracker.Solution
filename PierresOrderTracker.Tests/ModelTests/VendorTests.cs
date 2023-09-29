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

    [TestMethod]
    public void GetVendorId_ReturnsIdOfVendor_Int()
    {
      // Arrange
      int expectedId = 1;
      string name = "Not a fake vendor";
      Vendor newVendor = new Vendor(name);
      //Act 
      int testId = newVendor.Id;
      //Assert
      Assert.AreEqual(testId, expectedId);
    }
    [TestMethod]
    public void GetAllVendors_ReturnsAllInstancesOfVendors_VendorList()
    {
      // Arrange
      string name1 = "Not a fake vendor";
      string name2 = "Very sus vendor";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      //Act 
      List<Vendor> expectedList = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, expectedList);
    }

    [TestMethod]
    public void Find_ReturnsAllInstancesOfVendors_VendorList()
    {
      // Arrange
      string name1 = "Not a fake vendor";
      string name2 = "Very sus vendor";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      //Act 
      Vendor expectedVendor = Vendor.Find(2);
      //Assert
      Assert.AreEqual(newVendor2, expectedVendor);
    }
  }
}