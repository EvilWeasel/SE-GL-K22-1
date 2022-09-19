using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
  /// <summary>
  /// Wir implementieren hier das IProductModel Interface, damit wir
  /// für C# klarstellen, dass das "PhysicalProductModel" und das 
  /// "DigitalProductModel" gemeinsamkeiten haben. Wenn wir also gleich
  /// den Datentyp unserer Liste in der "Program.cs" zu "IProductModel"
  /// ändern, dann können wir darin alle Datentypen speichern, die dieses
  /// Interface implementieren.
  /// Das liegt daran, dass wir in diese Klasse durch den Vertrag festlegen,
  /// das alle Member des Interfaces von der Klasse implementiert werden MÜSSEN.
  /// </summary>
  public class PhysicalProductModel : IProductModel // BaseProductModel
  {
    public string Title { get; set; } = string.Empty;
    public bool HasOrderBeenCompleted { get; set; } = false;
    public void ShipItem(ICustomerModel customer)
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
