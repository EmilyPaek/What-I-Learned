using System;

namespace Example
{
  public class Program
  {
    static void Main(string[] args)
    {
      var snsFactory = new SNSFactory();
      snsFactory.create("Facebook");
      snsFactory.create("Instagram");
    }
  }
}
