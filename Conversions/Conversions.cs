using System;

namespace Intro {
  public class Conversions {
    public static void Main(string[] args) {
      int myInt = 5;
      Console.WriteLine(myInt);
      // 5
      long myLong = myInt;
      Console.WriteLine(myLong);
      // 5
      Console.WriteLine(myLong + myInt);
      // 10
      double myDouble = 5.1d;
      Console.WriteLine(myDouble);
      // 5.1
      myLong = (long) myDouble;
      Console.WriteLine(myLong);
      // 5
      myDouble = 5e9d;
      // 5 * 10^9
      Console.WriteLine(myDouble);
      // 5000000000
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
      // Implicit
      double minHeight = (double) heightInMeters;
      // Explicit
      float actualHeight = (float) maxHeight;
      // Explicit
      float maxHeightFloat = (float) maxHeight;
      // Compilation error if not cast!
      double d = 5e9d;
      // 5 * 10^9
      Console.WriteLine(d);
      // 5000000000
      try {
        int i = checked((int) d);
        // System.OverflowException
        Console.WriteLine(i);
      } catch (System.OverflowException soe) {
        Console.WriteLine("OverflowException caught");
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
