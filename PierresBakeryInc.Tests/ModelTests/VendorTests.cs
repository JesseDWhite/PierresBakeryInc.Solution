using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryInc.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryInc.Tests
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
      string name = "test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorNamurnsVendorName_String()
    {
      string name = "test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Stacies Bakery";
      string name02 = "Rons Rubarb";
      string description01 = "test description";
      string description02 = "test description";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Stacies Bakery";
      string name02 = "Rons Rubarb";
      string description01 = "test description";
      string description02 = "test description";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "Bread Loaf";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Stacies Bakery";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}