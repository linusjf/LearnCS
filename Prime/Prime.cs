using System;

namespace Intro {
  public class Prime {
    public static void Main(string[] args) {
      Console.Write("Enter a positive number: ");
      ulong num = ulong.Parse(Console.ReadLine());
      ulong divider = 2L;
      ulong maxDivider = (ulong) Math.Sqrt(num);
      bool prime = true;
      while (prime && (divider <= maxDivider)) {
        if (num % divider == 0) {
          prime = false;
        }
        divider++;
      }
      Console.WriteLine("Is " + num + " a prime?");
      Console.WriteLine("Prime? " + prime);
    }
  }
}
