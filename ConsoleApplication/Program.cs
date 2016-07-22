using System.Collections.Generic;
using DomainModel;

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      var data = new List<IInfoData>
      {
        new InfoData { FirstName = "Ivan", LastName = "Ivanov" },
        new InfoData { FirstName = "Fedor", LastName = "Petrov" },
        new InfoData { FirstName = "Andrey", LastName = "Sokolov" }
      };

      var source = new Source();
      source.CheckAndProceed(data);
    }
  }
}