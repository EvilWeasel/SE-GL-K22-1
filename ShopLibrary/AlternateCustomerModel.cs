using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  public class AlternateCustomerModel : ICustomerModel
  {
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public string GetFullName() => $"{FirstName} {LastName}";
    //public string GetFullName()
    //{
    //  return $"{FirstName} {LastName}";
    //}
  }
}
