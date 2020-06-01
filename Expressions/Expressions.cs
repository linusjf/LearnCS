using System;

namespace Intro {
  public class Expressions {
    public static void Main(string[] args) {
      int r = (150 - 20) / 2 + 5;
      // Expression for calculating the surface of the circle
      double surface = Math.PI * r * r;
      // Expression for calculating the perimeter of the circle
      double perimeter = 2 * Math.PI * r;
      Console.WriteLine(r);
      Console.WriteLine(surface);
      Console.WriteLine(perimeter);
      int a = 5;
      int b = ++a;
      // 6
      Console.WriteLine(a);
      // 6
      Console.WriteLine(b);
      // First example
      double d = 1 / 2;
      // 0, not 0.5
      Console.WriteLine(d);
      // Second example
      // 0.5
      double half = (double) 1 / 2;
      Console.WriteLine(half);
      int num = 1;
      // The value is 0.0 (real number)
      double denum = 0;
      // The value is 0 (integer number)
      int zeroInt = (int) denum;
      // Infinity
      Console.WriteLine(num / denum);
      // NaN
      Console.WriteLine(denum / denum);
      try {
        Console.WriteLine(zeroInt / zeroInt);
        // DivideByZeroException
      } catch (System.DivideByZeroException sdbze) {
        Console.WriteLine(sdbze.Message);
      }
      double incorrect = (double)((1 + 2) / 4);
      // 0
      Console.WriteLine(incorrect);
      double correct = ((double)(1 + 2)) / 4;
      // 0.75
      Console.WriteLine(correct);
      // 2 + 3 = 23
      Console.WriteLine("2 + 3 = " + 2 + 3);
      // 2 + 3 = 5
      Console.WriteLine("2 + 3 = " + (2 + 3));
    }
  }
}
