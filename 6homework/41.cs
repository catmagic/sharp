
using System;
class HelloWorld {
  static void Main() {
    int M= 5;
    int []arr=new int[M];
    for(int i=0; i<M;++i)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.Write($"{greaterzero(arr)}");
  }

    static int greaterzero(int[] arr)
    {
        int count=0;
        foreach(int num in arr)
        {
            if(num>0)
            {
                ++count;
            }
        }
        return count;
    }
}
