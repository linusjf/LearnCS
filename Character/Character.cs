using System;

namespace Intro {
  public class Character {
    public static void Main(string[] args) {
      // Declare a variable
      char ch = 'a';
      // Print the results on the console
      Console.WriteLine("The code of '" + ch + "' is: " + (int) ch);
      ch = 'b';
      Console.WriteLine("The code of '" + ch + "' is: " + (int) ch);
      ch = 'A';
      Console.WriteLine("The code of '" + ch + "' is: " + (int) ch);
      // Console output:
      // The code of 'a' is: 97
      // The code of 'b' is: 98
      // The code of 'A' is: 65
    }
  }
}
