using System;

namespace Intro {
  public class Conversions {
    public static void Main(string[] args) {
      int myInt = 5;
      // 5
      Console.WriteLine(myInt);
      long myLong = myInt;
      // 5
      Console.WriteLine(myLong);
      // 10
      Console.WriteLine(myLong + myInt);
      double myDouble = 5.1d;
      // 5.1
      Console.WriteLine(myDouble);
      myLong = (long) myDouble;
      // 5
      Console.WriteLine(myLong);
      // 5 * 10^9
      myDouble = 5e9d;
      // 5000000000
      Console.WriteLine(myDouble);
      myInt = (int) myDouble;
      Console.WriteLine(myInt);
      // -2147483648
      Console.WriteLine(int.MinValue);
      // -2147483648
      myLong = long.MaxValue;
      myInt = (int) myLong;
      Console.WriteLine(myLong);
      // 9223372036854775807
      Console.WriteLine(myInt);
      // -1
      float heightInMeters = 1.74f;
      // Explicit conversion
      double maxHeight = heightInMeters;
#pragma warning disable CS0219
      // Implicit
      double minHeight = (double) heightInMeters;
      // Explicit
      float actualHeight = (float) maxHeight;
      // Explicit
      float maxHeightFloat = (float) maxHeight;
#pragma warning restore CS0219
      // Compilation error if not cast!
      // 5 * 10^9
      double d = 5e9d;
      // 5000000000
      Console.WriteLine(d);
      try {
        int i = checked((int) d);
        // System.OverflowException
        Console.WriteLine(i);
      } catch (System.OverflowException soe) {
        Console.WriteLine("OverflowException caught: " + soe.Message);
      }
      int a = 5;
      int b = 7;
      string sum = "Sum = " + (a + b);
      Console.WriteLine(sum);
      String incorrect = "Sum = " + a + b;
      Console.WriteLine(incorrect);
      Console.WriteLine("Perimeter = " + 2 * (a + b) + ". Area = " + (a * b)
                        + ".");
    }
  }
}
