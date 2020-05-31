using System;

namespace Intro {
  public class Nullable {
    public static void Main(string[] args) {
      Nullable<int>i1 = null;
      int ? i2 = i1;
      Console.WriteLine(i2);
      int i = 5;
      int ? ni = i;
      Console.WriteLine(ni);
      // 5
      // i = ni;
      // this will fail to compile
      Console.WriteLine(ni.HasValue);
      // True
      i = ni.Value;
      Console.WriteLine(i);  // 5
      ni = null;
      Console.WriteLine(ni.HasValue);
      // False
      //i = ni.Value;
      // System.InvalidOperationException
      i = ni.GetValueOrDefault();
      Console.WriteLine(i);
      // 0
      string firstName = "John";
      string lastName = "Smith";
      int ? age = null;
      Console.WriteLine(firstName);
      Console.WriteLine(lastName);
      Console.WriteLine(age);
    }
  }
}
