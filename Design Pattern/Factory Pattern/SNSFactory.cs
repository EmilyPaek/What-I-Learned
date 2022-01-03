using System;

namespace Example
{
  public class SNSFactory
  {
    public SNS create(string type)
    {
      switch (type)
      {
        case "Twitter":
          return new Twitter();
          break;

        case "Facebook":
          return new Facebook();
          break;

        case "Instagram":
          return new Instagram();
          break;

        default:
          return null;
      }
    }
  }
}