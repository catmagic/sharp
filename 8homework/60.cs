using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    
    int[,,] arr=GetArray(3,10,3);
    PrintArray(arr);
    
    
  }
  static int[,,] GetArray(int n,int m, int k )
    {
        List<int> possibleint=new List<int>();
        int minrange=10;
        int maxrange=99;
        for(int i=minrange;i<=maxrange;++i )
        {
            possibleint.Add(i);
        }
        int [,,] result=new int[n,m,k];
        for(int i=0;i<n;++i)
        {
            
            for (int j = 0; j < m; ++j)
            {
                for (int l = 0; l < k; ++l)
                {
                    
                    
                    int  indexlist =new  Random().Next(0,possibleint.Count);
                    result[i,j,l]=possibleint[indexlist];
                    possibleint.RemoveAt(indexlist);
                }

            }
        }
        return result;
    }
    
    static void PrintArray(int[,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); ++i)
        {
            for (int j = 0; j < arr.GetLength(1); ++j)
            {
                for (int l = 0; l < arr.GetLength(2); ++l)
                {
               
                     Console.Write($"{arr[i,j,l]}({i},{j},{l}) ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        
    }
    
  
}

