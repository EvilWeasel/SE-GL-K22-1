using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  public interface IDigitalProductModel : IProductModel
  {
    public int TotalDownloadsLeft { get; set; }
  }
}
