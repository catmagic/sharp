using System;
class HelloWorld {
  static void Main() {
    int[] n=GetArray(8,-100,100);
   PrintArray(n);
   
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
 static int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);

    }
    return result;
}
static void PrintArray(int[] arr)
    {
       
    Console.Write('[');
    bool flag=false;
    foreach (int el in arr)
    {
        if(flag)
        {
             Console.Write($", {el}");
        }
        else
        {
            Console.Write($"{el}");
            flag=true;
        }
        
        
    }
    Console.Write("]");
    }
}
