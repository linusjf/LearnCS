namespace Intro {
  using System;
  class UsingReadLine {
    static void Main() {
      Console.Write("Please enter your first name: ");
      string firstName = Console.ReadLine();
      Console.Write("Please enter your last name: ");
      string lastName = Console.ReadLine();
      Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
    }
  }
  // Output: Please enter your first name: John
  // Please enter your last name: Smith
  // Hello, John Smith!
}
