using System.Collections.Generic;

namespace PierresBakeryInc.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string VendorName { get; set; }
    public int Id { get; }
    public List<Vendor> Vendors { get; set; }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
    }
  }
}