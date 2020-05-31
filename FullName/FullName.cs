using System;

namespace Intro {
  public class FullName {
    public static void Main(string[] args) {
      // Declare some variables
      string firstName = "John";
      string lastName = "Smith";
      string fullName = firstName + " " + lastName;
      // Print the results on the console
      Console.WriteLine("Hello, " + firstName + "!");
      Console.WriteLine("Your full name is " + fullName + ".");
      // Console output:
      // Hello, John!
      // Your full name is John Smith.
    }
  }
}
