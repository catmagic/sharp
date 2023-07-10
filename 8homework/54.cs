using System;
class HelloWorld {
  static void Main() {
    int[,] arr=GetArray(20,10,-100,100);
    PrintArray(arr);
    part_sort(arr);
    Console.WriteLine();
    PrintArray(arr);
    
  }
  static int[,] GetArray(int n,int m, int minValue, int maxValue)
    {
        int[,] result = new int[n,m];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
               
                result[i,j] =new  Random().Next(minValue,maxValue+1);

            }
        }
        return result;
    }
    
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); ++i)
        {
            for (int j = 0; j < arr.GetLength(1); ++j)
            {
                Console.Write($"{arr[i,j]} ");

            }
            Console.WriteLine();
        }
        
    }
    static void part_sort(int[,] arr)
    {
        for(int i=0;i<arr.GetLength(0);++i)
        {
            sort(arr,i);
        }
    }static void sort(int [,] arr,int index)
    {
        for(int i=0;i<arr.GetLength(1);++i)
        {
            for(int j=0;j<arr.GetLength(1)-1;++j)
            {
                if(arr[index,j]>arr[index,j+1])
                {
                    int tmp =arr[index,j];
                    arr[index,j]=arr[index,j+1];
                    arr[index,j+1]=tmp;
                }
            }
        }
    }
}

