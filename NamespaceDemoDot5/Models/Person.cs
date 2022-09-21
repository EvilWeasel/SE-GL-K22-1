using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemoDot5.Models
{
  internal class Person
  {
    string Vorname { get; set; } = string.Empty;
    string Nachname { get; set; } = string.Empty;
    public string getFullName()
    {
      return $"{Vorname} {Nachname}";
    }
  }
}
