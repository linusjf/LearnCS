namespace Intro {
using System;
  public class PrimeInterval {
    public static void Main(string[] args) {
      Console.Write("n = ");
      ulong n = ulong.Parse(Console.ReadLine());
      Console.Write("m = ");
      ulong m = ulong.Parse(Console.ReadLine());
      for (ulong num = n; num <= m; num++) {
        bool prime = true;
        ulong divider = 2L;
        ulong maxDivider = (ulong) Math.Sqrt(num);
        while (divider <= maxDivider) {
          if (num % divider == 0) {
            prime = false;
            break;
          }
          divider++;
        }
        if (prime) {
          Console.Write(" " + num);
        }
      }
    }
  }
}
