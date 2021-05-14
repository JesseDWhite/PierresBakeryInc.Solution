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
  }
}