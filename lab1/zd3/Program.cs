using System;
using System.Collections.Generic;
using System.Linq;

namespace Apis
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string s1 = "Мама";
      string s2 = "мылом";
      string s3 = "мыла";
      string s4 = "раму";

      Console.WriteLine($"{s1} {s2} {s3} {s4}");
      Console.WriteLine($"{s1}\n{s2}\n{s3}\n{s4}");

      Console.ReadLine();
    }
  }
}
