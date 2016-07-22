using System.Collections.Generic;
using DomainModel;

namespace ConsoleApplication
{
  class Source
  {
    public void CheckAndProceed(List<IInfoData> data)
    {
      var dest = new Destination();

      //do something

      dest.ProceedData(data);
    }
  }
}