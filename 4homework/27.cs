
using System;
class HelloWorld {
  static void Main() {
    int n=Prompt("число");
   
    Console.WriteLine($"сумма чисел {sumdigit(n)}");
  }
  static int sumdigit(int n)
  {
      int sum=0;
      while(n!=0)
      {
          sum+=n%10;
          n/=10;
      }
      return sum;
  }
  static int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
}

