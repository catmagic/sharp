using System;
class HelloWorld 
{
    static void Main() 
    {
        int [,]arr=GetArrayDouble(3,4,0,100);
        double[] res=averege(arr);
        PrintArray(arr);
        Console.WriteLine();
        PrintArray(res);
    }
    static double[,] GetArrayDouble(int n,int m, double minValue, double maxValue)
    {
        double[,] result = new double[n,m];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                double coeff= new Random().NextDouble();
                result[i,j] =minValue+(maxValue-minValue)*coeff;

            }
        }
        return result;
    }
    static int[,] GetArrayDouble(int n,int m, int minValue, int maxValue)
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
    static void PrintArray(double[,] arr)
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
    static void PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; ++i)
        {      
            Console.Write($"{arr[i]} ");

        }
        Console.WriteLine();
        
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
    static double[] averege(int [,]arr)
    {
        double[] result=new double[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); ++i)
        {
            result[i]=0;
            for (int j = 0; j < arr.GetLength(0); ++j)
            {
                result[i]+=arr[j,i];

            }
            result[i]/= arr.GetLength(0);
        }
        return result;
    }
}

