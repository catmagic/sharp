using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Console.WriteLine("Введите 1 числа");
    int a=int.Parse(Console.ReadLine());
    
    if(a%2)
    {
       Console.WriteLine("Нет");
    }
    else
    {
       Console.WriteLine("Да");
    }
    
  }
}
