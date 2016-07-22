using System.Collections.Generic;
using DomainModel;

namespace ConsoleApplication
{
  class Destination
  {
    public void ProceedData(List<IInfoData> data)
    {
      foreach (var item in data)
      {
        //do something
      }
    }
  }
}