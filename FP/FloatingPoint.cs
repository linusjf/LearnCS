using System;

namespace Intro {
  public class FloatingPoint {
    public static void Main(string[] args) {
      float floatPI = 3.14f;
      // 3.14
      Console.WriteLine(floatPI);
      double doublePI = 3.14;
      // 3.14
      Console.WriteLine(doublePI);
      double nan = Double.NaN;
      // NaN
      Console.WriteLine(nan);
      double infinity = Double.PositiveInfinity;
      // Infinity
      Console.WriteLine(infinity);

      // Declare some variables
      floatPI = 3.141592653589793238f;
      doublePI = 3.141592653589793238;
      // Print the results on the console
      Console.WriteLine("Float PI is: " + floatPI);
      Console.WriteLine("Double PI is: " + doublePI);
      // Console output:
      // Float PI is: 3.141593
      // Double PI is: 3.14159265358979
      float f = 0.1f;
      Console.WriteLine(f);
      // 0.1 (correct due to rounding)
      double d = 0.1f;
      Console.WriteLine(d);
      // 0.100000001490116 (incorrect)
      float ff = 1.0f / 3;
      Console.WriteLine(ff);
      // 0.3333333 (correct due to rounding)
      double dd = ff;
      Console.WriteLine(dd);
      // 0.333333343267441 (incorrect)
      decimal decimalPI = 3.14159265358979323846m;
      Console.WriteLine(decimalPI);
      // 3.14159265358979323846
    }
  }
}
