using System;
class HelloWorld {
  static void Main() {
    int[,] arr=GetArray(10,10,0,10);
    PrintArray(arr);
    
    Console.WriteLine($"\n {indexminsum(arr)}");
    
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
    static int indexminsum(int [,]arr)
    {
        int summin=sum(arr,0);
        int index=0;
        for(int i=1;i<arr.GetLength(1);++i)
        {
            int sumtmp=sum(arr,i);
            if(summin>sumtmp)
            {
                summin=sumtmp;
                index=i;
            }
        }
        return index+1;
    }
    static int sum(int [,] arr,int index)
    {
        int sum=0;
        
        for(int j=0;j<arr.GetLength(0);++j)
        {
            sum+=arr[j,index];
        }
        return sum;
    }
}
