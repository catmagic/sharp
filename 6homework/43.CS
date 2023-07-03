using System;
class HelloWorld {
  static void Main() 
  {
   int k1=Prompt("k1:");
   int b1=Prompt("b1:");
   
   int k2=Prompt("k2:");
   int b2=Prompt("b2:");
   
   var solution=crosselines(k1,  b1,k2,b2);
   int configuration=solution.Item1;
   double x=solution.Item2;
   double y=solution.Item3;
   if(configuration==2)
   {
       Console.Write("infinity point");
   }
   else if(configuration==1)
   {
       Console.Write("no point");
   }
   else{ Console.Write($"({x},{y})");}
  }
  static int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
  static (int ,double ,double) crosselines(int k1, int b1,int k2,int b2)
  {
      int type=(k1==k2)?((b1==b2)?2:1):0;
      if(type==2||type==1)
      {
          return (type,0,0);
      }
      return (type,1.0*(b2-b1)/(k1-k2),1.0*(b2*k1-b1*k2)/(k1-k2));
  }
}
