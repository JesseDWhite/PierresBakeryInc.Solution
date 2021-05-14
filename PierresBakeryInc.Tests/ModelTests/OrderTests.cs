using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryInc.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryInc.Tests
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
      Order newOrder = new Order("bread loaf");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string order = "bread loaf";
      Order newOrder = new Order(order);
      string result = newOrder.OrderItem;
      Assert.AreEqual(order, result);
    }
  }
}