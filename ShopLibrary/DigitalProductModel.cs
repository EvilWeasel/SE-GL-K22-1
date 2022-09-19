using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  public class DigitalProductModel : IProductModel
  {
    //public string Title { get; set; } = string.Empty;
    //public bool HasOrderBeenCompleted { get; set; } = false;
    public int TotalDownloadsLeft { get; set; } = 5;
    public bool HasOrderBeenCompleted { get; set; } = false;
    public string Title { get; set; } = string.Empty;

    public void ShipItem(CustomerModel customer)
    {
      if (!HasOrderBeenCompleted)
      {
        Console.WriteLine(
          $"Simulating emailing of {Title} to {customer.FirstName} {customer.LastName} via: {customer.EmailAddress}");
        TotalDownloadsLeft--;
        if (TotalDownloadsLeft < 1)
        {
          HasOrderBeenCompleted = true;
        }
      }
    }
  }
}
