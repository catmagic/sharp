using System;
class HelloWorld 
{
    static void Main() 
    {
        double [,]arr=GetArrayDouble(10,9,0.0,100.0);
        PrintArray(arr);
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
}

