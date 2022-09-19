using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  public class BaseProductModel
  {
    public string Title { get; set; } = string.Empty;
    public bool HasOrderBeenCompleted { get; set; } = false;
    public virtual void ShipItem(CustomerModel customer)
    {
      if (!HasOrderBeenCompleted)
      {
        Console.WriteLine(
          $"Simulating shipping of {Title} to {customer.FirstName} {customer.LastName} in {customer.City}.");
        HasOrderBeenCompleted = true;
      }
    }
  }
}
