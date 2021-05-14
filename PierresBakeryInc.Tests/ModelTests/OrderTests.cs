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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "bread loaf";
      string description02 = "pastry";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "bread loaf";
      Order newOrder = new Order(description);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "bread loaf";
      string description02 = "pastry";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}