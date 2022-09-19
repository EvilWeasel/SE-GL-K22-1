namespace ShopLibrary
{
  /// <summary>
  /// Interfaces sind wie Verträge. In dem Interface definieren wir
  /// welche "Member" die Klasse implementieren muss, in der wir
  /// das Interface einbauen.
  /// Access-Modifier (public, internal,...) muss hier nicht definiert werden,
  /// genau so wenig wie die Implementation (Methoden-Körper, Instanzen von Variablen, usw.)
  /// </summary>
  public interface IProductModel
  {
    bool HasOrderBeenCompleted { get; set; }
    string Title { get; set; }
    void ShipItem(ICustomerModel customer);
  }
}