using System;

namespace Intro {
  public class Operators {
    public static void Main(string[] args) {
      MathOperators();
      LogicalOperators();
      BitWiseOperators();
    }

    public static void MathOperators() {
      int squarePerimeter = 17;
      double squareSide = squarePerimeter / 4.0;
      double squareArea = squareSide * squareSide;
      // 4.25
      Console.WriteLine(squareSide);
      // 18.0625
      Console.WriteLine(squareArea);
      int a = 5;
      int b = 4;
      // 9
      Console.WriteLine(a + b);
      // 9
      Console.WriteLine(a + (b++));
      // 10
      Console.WriteLine(a + b);
      // 11
      Console.WriteLine(a + (++b));
      // 11
      Console.WriteLine(a + b);
      // 2
      Console.WriteLine(14 / a);
      // 4
      Console.WriteLine(14 % a);
      int one = 1;
      int zero = 0;
      // Console.WriteLine(one / zero);
      // DivideByZeroException
      double dMinusOne = -1.0;
      double dZero = 0.0;
      // -Infinity
      Console.WriteLine(dMinusOne / zero);
      // Infinity
      Console.WriteLine(one / dZero);
    }

    public static void LogicalOperators() {
      bool a = true;
      bool b = false;
      // False
      Console.WriteLine(a && b);
      // True
      Console.WriteLine(a || b);
      // True
      Console.WriteLine(!b);
      // True
      Console.WriteLine(b || true);
      // False
      Console.WriteLine((5 > 7) ^ (a == b));
    }

    public static void BitWiseOperators() {
      // 0000 0011 = 3
      byte a = 3;
      // 0000 0101 = 5
      byte b = 5;
      // 0000 0111 = 7
      Console.WriteLine(a | b);
      // 0000 0001 = 1
      Console.WriteLine(a & b);
      // 0000 0110 = 6
      Console.WriteLine(a ^ b);
      // 0000 0100 = 4
      Console.WriteLine(~a & b);
      // 0000 0110 = 6
      Console.WriteLine(a << 1);
      // 0000 1100 = 12
      Console.WriteLine(a << 2);
      // 0000 0001 = 1
      Console.WriteLine(a >> 1);
    }
  }
}
