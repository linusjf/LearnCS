using System;

namespace Intro {
  public class Operators {
    public static void Main(string[] args) {
      MathOperators();
      LogicalOperators();
      BitWiseOperators();
      ComparisonOperators();
      AssignmentOperators();
      ConditionalOperators();
      OtherOperators();
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

    public static void ComparisonOperators() {
      int x = 10, y = 5;
      // True
      Console.WriteLine("x > y : " + (x > y));
      // False
      Console.WriteLine("x < y : " + (x < y));
      // True
      Console.WriteLine("x >= y : " + (x >= y));
      // False
      Console.WriteLine("x <= y : " + (x <= y));
      // False
      Console.WriteLine("x == y : " + (x == y));
      // True
      Console.WriteLine("x != y : " + (x != y));
    }

#pragma warning disable 219
    public static void AssignmentOperators() {
      int x = 6;
      string helloString = "Hello string.";
      int y = x;
      int z;
      x = y = z = 25;
      y = 4;
      // Same as x = x * y;
      x *= y;
      // 8
      Console.WriteLine(x);
      // 8
      Console.WriteLine(y *= 2);
      // y=3 and z=3
      z = y = 3;
      // 3
      Console.WriteLine(z);
      // 7
      Console.WriteLine(x |= 1);
      // 10
      Console.WriteLine(x += 3);
      // 5
      Console.WriteLine(x /= 2);
    }
#pragma warning restore 219

    public static void ConditionalOperators() {
      int a = 6;
      int b = 4;
      // a>b
      Console.WriteLine(a > b ? "a>b" : "b<=a");
      // num will have value -1
      int num = a == b ? 1 : -1;
    }

    public static void OtherOperators() {
      // Prints the date + time
      Console.WriteLine(DateTime.Now);
      int[] arr = {1, 2, 3};
      // 1
      Console.WriteLine(arr[0]);
      string str = "Hello";
      // e
      Console.WriteLine(str[1]);
      int ? a = 5;
      // 5
      Console.WriteLine(a ?? - 1);
      string name = null;
      // (no name)
      Console.WriteLine(name ?? "(no name)");
      a = 6;
      int b = 3;
      Console.WriteLine(a + b / 2);    // 7
      Console.WriteLine((a + b) / 2);  // 4
      string s = "Beer";
      Console.WriteLine(s is string);  // True
      string notNullString = s;
      string nullString = null;
      // Unspecified
      Console.WriteLine(nullString ?? "Unspecified");
      // Beer
      Console.WriteLine(notNullString ?? "Specified");
    }
  }
}
