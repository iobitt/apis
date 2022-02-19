using System;
using System.Collections.Generic;
using System.Linq;

namespace Apis
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int a;

      bool success = int.TryParse(Console.ReadLine(), out a);
      if (success)
        Console.WriteLine(Math.Pow(a, 2));
      else
        Console.WriteLine("Некорректные входные данные!");

      Console.ReadLine();
    }
  }
}
