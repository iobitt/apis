using System;
using System.Collections.Generic;
using System.Linq;

namespace Apis
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int a = 5;
      int b = 7 , c = 10;
      int d = 82;
      int e = 17;

      int s = a + b + c + d + e;
      Console.WriteLine("Сумма всех значений равна: {0}", s);

      Console.ReadLine();
    }
  }
}
