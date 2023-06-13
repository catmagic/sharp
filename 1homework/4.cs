using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Console.WriteLine("Введите 3 числа");
    Console.WriteLine("Введите первое число");
    int a=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int c=int.Parse(Console.ReadLine());
    int max;
    if(a>b)
    {
        max=a;
    }
    else
    {
        max=b;
    }
    if(max<c)
    {
        max=c;
    }
    Console.WriteLine($"max = {max}");
  }
}

