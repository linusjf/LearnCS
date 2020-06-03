using System;

namespace Intro {
  public class Conditional {
    public static void Main(string[] args) {
      printComparisons();
      compareCharsInts();
      compareRefs();
    }

    public static void compareCharsInts() {
      // True
      Console.WriteLine("char 'a' == 'a'? " + ('a' == 'a'));
      // False
      Console.WriteLine("char 'a' == 'b'? " + ('a' == 'b'));
      // True
      Console.WriteLine("5 != 6? " + (5 != 6));
      // True
      Console.WriteLine("5.0 == 5L? " + (5.0 == 5L));
      // False
      Console.WriteLine("true == false? " + (true == false));
    }

    public static void compareRefs() {
      string str = "beer";
      string anotherStr = str;
      string thirdStr = "bee";
      thirdStr = thirdStr + 'r';
      Console.WriteLine("str = {0}", str);
      Console.WriteLine("anotherStr = {0}", anotherStr);
      Console.WriteLine("thirdStr = {0}", thirdStr);
      // True - same object
      Console.WriteLine(str == anotherStr);
      // True - equal objects
      Console.WriteLine(str == thirdStr);
      // True
      Console.WriteLine((object) str == (object) anotherStr);
      // False
      Console.WriteLine((object) str == (object) thirdStr);
    }

    public static void printComparisons() {
      int weight = 700;
      // True
      Console.WriteLine(weight >= 500);
      char gender = 'm';
      // False
      Console.WriteLine(gender <= 'f');
      double colorWaveLength = 1.630;
      Console.WriteLine(colorWaveLength > 1.621);  // True
      int a = 5;
      int b = 7;
      bool condition = (b > a) && (a + b < a * b);
      // True
      Console.WriteLine(condition);
      // True
      Console.WriteLine('B' == 'A' + 1);
    }
  }
}
