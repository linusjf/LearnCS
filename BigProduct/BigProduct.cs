namespace Intro {
  using System;
  using System.Numerics;
  class BigProduct {
    static void Main() {
      Console.Write("n = ");
      int n = int.Parse(Console.ReadLine());
      Console.Write("m = ");
      int m = int.Parse(Console.ReadLine());
      int num = n;
      BigInteger product = 1;
      do {
        product *= num;
        num++;
      } while (num <= m);
      Console.WriteLine("product[" + n + "..." + m + "] = " + product);
    }
  }
}
