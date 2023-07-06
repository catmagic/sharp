using System;
class HelloWorld 
{
    static void Main() 
    {
        int [,]arr=GetArrayDouble(3,4,0,100);
        PrintArray(arr);
        int i=getNumber("i");
        int j=getNumber("j");
        var res=find(arr,i,j);
        if(!res.Item1)
        {
            Console.WriteLine("числа на этой позиции нет");
        }
        Console.WriteLine($"{res.Item2}");
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
    static (bool,int) find(int [,]arr,int i, int j)
    {
        if(i>=arr.GetLength(0)||j>=arr.GetLength(1)||i<0||j<0)
        {
            return (false,0);
        }
        return (true,arr[i,j]);
        
    }
    static int getNumber(string s)
    {
        Console.WriteLine(s);
        return Convert.ToInt32(Console.ReadLine());
    }
}

