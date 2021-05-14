using System.Collections.Generic;

namespace PierresBakeryInc.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public string OrderItem { get; set; }
    public int Id { get; }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public Order(string orderItem)
    {
      OrderItem = orderItem;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}