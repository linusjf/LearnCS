namespace Intro {
  using System;

  class CustomNumericFormats {
    static void Main() {
      Console.WriteLine("{0:0.00}", 1);
      //Output: 1.00
      Console.WriteLine("{0:#.##}", 0.234);
      //Output: .23
      Console.WriteLine("{0:#####}", 12345.67);
      //Output: 12346
      Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
      //Output: (02) 934 25 25
      Console.WriteLine("{0:%##}", 0.234);
      //Output: %23
    }
  }
}
