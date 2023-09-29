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
  }

}