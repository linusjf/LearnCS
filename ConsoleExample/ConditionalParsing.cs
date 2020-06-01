namespace Intro {
  using System;
  class ConditionalParsing {
    static void Main() {
      string str = Console.ReadLine();
      int intValue;
      bool parseSuccess = Int32.TryParse(str, out intValue);
      Console.WriteLine(parseSuccess ? "The square of the number is "
                            + intValue * intValue + "."
                        : "Invalid number!");
      str = Console.ReadLine();
      parseSuccess = Int32.TryParse(str, out intValue);
      Console.WriteLine(parseSuccess ? "The square of the number is "
                            + intValue * intValue + "."
                        : "Invalid number!");
    }
  }
}
