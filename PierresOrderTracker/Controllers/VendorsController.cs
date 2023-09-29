using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresOrderTracker.Models;

namespace PierresOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    //for adding new vendors
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendorToView = Vendor.Find(id);
      List<Order> vendorOrder = vendorToView.Order;
      model.Add("vendor", vendorToView);
      model.Add("order", vendorOrder);
      return View(model);
    }

    //for adding new orders to a vendor
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> categoryOrders = foundVendor.Order;
      model.Add("order", categoryOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }

}