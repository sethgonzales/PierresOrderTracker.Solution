using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace PierresOrderTracker.Models
{

  public class Order
  {
    public string Title { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> { };


    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAllOrders()
    {
      return _instances;
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId - 1];
    }
  }
}