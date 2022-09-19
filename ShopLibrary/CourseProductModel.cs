using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  public class CourseProductModel : ICourseProductModel
  {
    public DateTime ExpiryDate { get; set; }
    public bool HasOrderBeenCompleted { get; set; }
    public string Title { get; set; } = string.Empty;

    public void ShipItem(ICustomerModel customer)
    {
      if (!HasOrderBeenCompleted)
      {
        Console.WriteLine(
          $"Simulating shipping of {Title} to {customer.FirstName} {customer.LastName} in {customer.City}.");
        ExpiryDate = DateTime.Now.AddDays(7);
        HasOrderBeenCompleted = true;
      }
    }
  }
}
