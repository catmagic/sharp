using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите число");
    int a=int.Parse(Console.ReadLine());
    string s="";
    for(int i=2;i<=a;i+=2)
    {
        if(i==2)
        {
            s=i.ToString();
        }
        else
        {
            s+=", "+i.ToString();
        }
    }
    
    Console.WriteLine($"{s}");
  }
}

