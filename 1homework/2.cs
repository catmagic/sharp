using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Console.WriteLine("Введите 2 числа");
    Console.WriteLine("Введите первое число");
    int a=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b=int.Parse(Console.ReadLine());
    int max;
    if(a>b)
    {
        max=a;
    }
    else
    {
        max=b;
    }
    Console.WriteLine($"max = {max}");
  }
}

