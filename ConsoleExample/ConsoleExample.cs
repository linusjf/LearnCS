using System;

namespace Intro {
  public class ConsoleExample {
    public static void Main(string[] args) {
      printData();
      printWrite();
      printConcat();
      printFormatted();
    }

    public static void printData() {
      // Print String
      Console.WriteLine("Hello World");
      // Print int
      Console.WriteLine(5);
      // Print double
      Console.WriteLine(3.14159265358979);
    }

    public static void printWrite() {
      Console.WriteLine("I love");
      Console.Write("this ");
      Console.Write("Book!");
    }

    public static void printFormatted() {
      string str = "Hello World!";
      // Print (the normal way)
      Console.Write(str);
      // Print (through formatting string)
      Console.Write("{0}", str);
      string name = "John";
      int age = 18;
      string town = "Seattle";
      Console.Write("{0} is {1} years old from {2}!\n", name, age, town);
      Console.WriteLine("{0,6}", 123);
      Console.WriteLine("{0,6}", 1234);
      Console.WriteLine("{0,6}", 12);
      Console.Write("{0,-6}", 123);
      Console.WriteLine("--end");
      DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
      Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
      Console.WriteLine("{0:d.MM.yy}", d);
      Console.WriteLine("{0:G}", DayOfWeek.Wednesday);
      Console.WriteLine("{0:D}", DayOfWeek.Wednesday);
      Console.WriteLine("{0:X}", DayOfWeek.Wednesday);
    }

    public static void printConcat() {
      object age = "twenty six";
      string text = "He is " + age + " years old.";
      Console.WriteLine(text);
      age = 26;
      text = "He is " + age + " years old.";
      Console.WriteLine(text);
      string s = "Four: " + 2 + 2;
      // Four: 22
      Console.WriteLine(s);
      string s1 = "Four: " + (2 + 2);
      // Four: 4
      Console.WriteLine(s1);
    }
  }
}
