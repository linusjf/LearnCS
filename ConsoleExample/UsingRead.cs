namespace Intro {
  using System;
  class UsingRead {
    static void Main() {
      int codeRead = 0;
      do {
        codeRead = Console.Read();
        if (codeRead != 0) {
          Console.Write((char) codeRead);
        }
      } while (codeRead != 10);
    }
  }
}
