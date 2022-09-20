namespace Algorithms
{
  public class CardGame
  {
    /*
    * Alice hat einige Karten auf denen Zahlen stehen. Sie sortiert die Karten in absteigender Reihenfolge, 
    * und legt diese in einer Reihe mit der Schrift unten auf den Tisch.
    * Nun soll Bob die Karte mit einer, von Alice vorgegebenen Zahl finden UND dabei so wenig falsche
    * Karten wie möglich aufzudecken.
    * 
    * Schreiben Sie eine Helfer Funktion für den armen Bob.
    */

    // var my_var = LocateCard([32,16,8,4,2,1,0], 2) 
    // public static int LocateCard(List<int> cards, int query)

    // 1. Loop: foreach card
    // 2. If number at card == query True: return index of card in cards
    // 3. If number at card == query False: repeat
    // 4. If query not found: ???

    // 1. Create: variable indexPosition = 0
    // 2. WHILE true
    // 3. If number at indexPosition == query: return indexPosition
    // 4. Increment position by one and REPEAT

    // variable = 10

    public static int LocateCard(List<int> cards, int query)
    {
      var indexPosition = 0;
      while (true)
      {
        if (cards.Count <= 0)
        {
          return -1;
        }
        if (cards[indexPosition] == query)
        {
          return indexPosition;
        }
        if (indexPosition == cards.Count() - 1)
        {
          return -1;
        }
        indexPosition++;
      }
    }

    //    // Kopfgesteurte (While-) Schleife
    //    var i = 0;
    //      while (i< 10) // Tue x, solange wahr == wahr
    //      {
    //        //do stuff
    //        i++;
    //      }

    //      // Fussgesteuerte (While-) Schleife
    //      do
    //      {

    //      } while (true) ;

    //for (int i = 0; i < length; i++)
    //{
    //  Console.WriteLine(collection[i]);
    //}

    //foreach (var item in collection)
    //{
    //  Console.WriteLine(item);
    //}

    //public static int LocateCard(List<int> cards, int query)
    //{

    //  while (true)
    //  {
    //    if (random)
    //    {
    //      continue;
    //    }



    //    // hier
    //    if (random)
    //    {
    //      break;
    //    }

    //    // hier

    //  }
    //  // goes here after break!

    //}
  }
}