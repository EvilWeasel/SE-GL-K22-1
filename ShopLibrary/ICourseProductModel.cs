using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  public interface ICourseProductModel : IProductModel
  {
    DateTime ExpiryDate { get; set; }
  }
}
