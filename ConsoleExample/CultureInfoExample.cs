namespace Intro {

  using System;
  using System.Threading;
  using System.Globalization;
  class CultureInfoExample {
    static void Main() {
      DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
      Console.WriteLine("{0:N}", 1234.56);
      Console.WriteLine("{0:D}", d);
      Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
      Console.WriteLine("{0:N}", 1234.56);
      Console.WriteLine("{0:D}", d);
    }
  }
}
