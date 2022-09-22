Console.WriteLine("Start");
// code goes here
/* IEnumerable.something => Ermöglicht nutzen von Linq Methoden */
// var people = DataAccess.GetPeople().Take(2);
//   //.Where(x => x.FirstName == "Anna");
// foreach (var p in people)
// {
//   // do work
//   Console.WriteLine($"{p.FirstName} {p.LastName} READY.");
// }
var primeNumbers = Generators.GetPrimeNumbers().Take(10);

var iterator = primeNumbers.GetEnumerator();

Console.WriteLine("--while--");
while (iterator.MoveNext())
{
  Console.WriteLine(iterator.Current);
}

Console.WriteLine("--foreach--");

foreach (var prime in primeNumbers)
{
  Console.WriteLine(prime);
}


Console.WriteLine("End");


public class DataAccess
{
  public static IEnumerable<PersonModel> GetPeople()
  {
    yield return new PersonModel("Hans", "Schmidt");
    yield return new PersonModel("Anna", "Bauer");
    yield return new PersonModel("Tommy", "Mühläcker");
    //IEnumerable<PersonModel> people = new List<PersonModel>();
    // Generate Persons
    //return people;
  }
}