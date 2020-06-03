namespace Intro {
  using System;
  using System.Numerics;
  class Factorial {
    static void Main() {
      Console.Write("n = ");
      int n = int.Parse(Console.ReadLine());
      int orig = n;
      BigInteger factorial = 1;
      do {
        factorial *= n;
        n--;
      } while (n > 0);
      Console.WriteLine(orig + "! = " + factorial);
    }
  }
}
