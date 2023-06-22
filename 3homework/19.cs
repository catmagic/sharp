using System;
class HelloWorld {
  static void Main() {
      int  fivedigit=getNumber("введите 5-ти значное число");
      if(ispolidrom(fivedigit)&&isfivedigit(fivedigit))
      {
          Console.WriteLine("полиндром");
      }
      else if(!isfivedigit(fivedigit))
      {
          Console.WriteLine("не пятизначное");
      }else
      {
          Console.WriteLine("не полиндром");
      }
    
  }
  static bool ispolidrom(int fivedigit)
  {
      return (fivedigit/10000==fivedigit%10)&&((fivedigit/1000)%10==(fivedigit/10)%10);
  }
  static int getNumber(string s)
  {
      Console.WriteLine(s);
      return Convert.ToInt32(Console.ReadLine());
  }
  static bool isfivedigit(int fivedigit)
  {
      return (fivedigit/10000>0)&&(fivedigit/100000==0);
  }
}

