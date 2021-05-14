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
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorNamurnsVendorName_String()
    {
      string name = "test Vendor";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
  }
}