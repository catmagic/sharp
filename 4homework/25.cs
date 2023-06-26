using System;
class HelloWorld {
  static void Main() {
    int n=Prompt("основание степени");
    int m=Prompt("степень");
    Console.WriteLine($"{mypow(n,m)}");
  }
  static int mypow(int n,int m)
  {
      if (m==0){
      return 1;
      }
      if(m==1)
      {
          return n;
      }
      int tmp=mypow(n,m/2);
      int l=1;
      if(m%2==1)
      {
          l=n;
      }
      return tmp*tmp*l;
  }
  static int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
}
