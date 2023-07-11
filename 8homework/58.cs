using System;
class HelloWorld {
  static void Main() {
    int n,m,k;
    m=2;
    k=1;
    n=3;
    int[,] arr1=GetArray(m,k,0,10);
    int[,] arr2=GetArray(k,n,0,10);
    PrintArray(arr1);
    Console.WriteLine();
    PrintArray(arr2);
    Console.WriteLine();
    PrintArray(product(arr1,arr2));
    Console.WriteLine();

    
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
    static int[,] product(int[,]arr1,int[,]arr2)
    {
        int[,] result=new int[arr1.GetLength(0),arr2.GetLength(1) ];
        for(int i=0;i<arr1.GetLength(0);++i)
        {
            for(int j=0;j<arr2.GetLength(1);++j)
            {
                result[i,j]=0;
                for(int k=0;k<arr1.GetLength(1);++k)
                {
                    result[i,j]+=arr1[i,k]*arr2[k,j];
                }
            }
        }
        return result;
    }
    
}

