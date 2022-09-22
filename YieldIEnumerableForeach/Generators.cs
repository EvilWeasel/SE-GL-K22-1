// code goes here
/* IEnumerable.something => Ermöglicht nutzen von Linq Methoden */
// var people = DataAccess.GetPeople().Take(2);
//   //.Where(x => x.FirstName == "Anna");
// foreach (var p in people)
// {
//   // do work
//   Console.WriteLine($"{p.FirstName} {p.LastName} READY.");
// }



public class Generators
{
  public static IEnumerable<int> GetPrimeNumbers()
  {
    int counter = 2;

    while (true)
    {
      if (IsPrimeNumber(counter))
      {
        yield return counter;
      }
      counter++;
    }
  }

  public static bool IsPrimeNumber(int number)
  {
    bool result = true;

    for (int i = 2; i < number; i++)
    {
      if (number % i == 0)
      {
        result = false;
        /* Beendet die Schleife vorzeitig, wenn number restlos durch eine andere Zahl teilbar ist */
        break;
      }
    }
    return result;
  }
}
