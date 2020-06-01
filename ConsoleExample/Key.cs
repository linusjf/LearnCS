namespace Intro {
  using System;
  class Key {
    static void Main() {
      ConsoleKeyInfo key = Console.ReadKey();
      Console.WriteLine();
      Console.WriteLine("Character entered: " + key.KeyChar);
      Console.WriteLine("Special keys: " + key.Modifiers);
    }
  }
}
