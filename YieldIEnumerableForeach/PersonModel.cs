public class PersonModel
{
  public string FirstName { get; set; } = string.Empty;
  /* strg + d => duplicate line */
  public string LastName { get; set; } = string.Empty;

  public PersonModel(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
    Console.WriteLine($"Benutzer {FirstName} {LastName} wurde initialisiert.");
  }
}