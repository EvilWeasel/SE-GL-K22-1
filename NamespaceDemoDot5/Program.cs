using System;
using static System.Console;

namespace NamespaceDemoDot5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
       Multi-Cursor-Select => shift+alt oder shift+opt (osx)
       */
      DataAccess dataAccess0 = new DataAccess();
      DataAccess dataAccess1 = new DataAccess();
      DataAccess dataAccess2 = new DataAccess();
      DataAccess dataAccess3 = new DataAccess();
      OldDataAccess oldDataAccess0 = new OldDataAccess();
      // strg + d
      OldDataAccess oldDataAccess1 = new OldDataAccess();

      // Person Beispiel
      DataModels.Person p0 = new DataModels.Person();
      DataModels.Person p1 = new DataModels.Person();

      Models.Person p2 = new Models.Person();
      Models.Person p3 = new Models.Person();

      // Scopes => Namespaces
      // Console c = new Console();
      WriteLine("Hello World!");
    }
  }
}
