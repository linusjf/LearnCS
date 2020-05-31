using System;

namespace Intro {
  public class Escapes {
    public static void Main(string[] args) {
      // An ordinary character
      char character = 'a';
      Console.WriteLine(character);
      // Unicode character code in a hexadecimal format
      character = '\u003A';
      Console.WriteLine(character);
      // Assigning the single quotiation character (escaped as \')
      character = '\'';
      Console.WriteLine(character);
      // Assigning the backslash character (escaped as \\)
      character = '\\';
      Console.WriteLine(character);
      // Console output:
      // a
      // :
      // '
      // \
    }
    }
  }
