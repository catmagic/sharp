using System;
class HelloWorld {
  static void Main() {
     int a=int.Parse(Console.ReadLine());
     while(a>1000)
     {
        a/=10;
     }
     if(a<100)
     {
         Console.WriteLine("Нет тетьего знака");
     }
     else
     {
         Console.WriteLine($"{a%10}");
     }
  }
}

