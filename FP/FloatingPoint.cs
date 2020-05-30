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
    }
  }
}
