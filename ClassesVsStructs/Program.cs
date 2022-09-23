/* 
 * Value-Types (Werte-Typen):
 * - int, float, decimal, double, long, short
 * - boolean
 * - enum
 * - struct
 * 
 * Reference-Types (Referenz-Typen):
 * - string
 * - class
 * - objekte
 * - array
 * 
 */

Console.WriteLine("Start");
// code goes here...
List<MyClass> classList = new List<MyClass>();
classList.Add(new MyClass(10));
classList.Add(new MyClass(42));
foreach (var item in classList)
{
  // print FirstName and LastName
  Console.WriteLine(item);
}

object hello = "hello";


Console.WriteLine("End");

public class MyClass
{
  public int Value { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Lastname { get; set; } = string.Empty;
  public MyClass(int value)
  {
    Value = value;
  }

  public override string ToString()
  {
    return $"{Value}";
  }

}