using System;
class HelloWorld {
  static void Main() {
    int[,]result=GetArray(10,11);
    PrintArray(result);
  }
   static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
  static int[,] GetArray(int n,int m)
    {
        int[,] result = new int[n,m];
        for(int i=0;i<n;++i)
        {
            for(int j=0;j<m;++j)
            {
                result[i,j]=0;
            }
        }
        int iindex=0;
        int jindex=0;
        int value=1;
        int condition=0;
        
        while ( value+1 <=n*m)
        {
            
           
           if(condition==0)
           {
               if(iindex+1==n)
               {
                   condition=1;
                   
               }
               else if(result[iindex+1,jindex]!=0)
               {
                   condition=1;
                   
                   
               }else
               {
                   result[iindex++,jindex]=value++;
               }
               
           }
           if(condition==1)
           {
               if(jindex+1==m)
               {
                   condition=2;
                  
               }
               else if(result[iindex,jindex+1]!=0)
               {
                   condition=2;
                   
                   
               }else
               {
                   result[iindex,jindex++]=value++;
               }
               
           }
           if(condition==2)
           {
               if(iindex==0)
               {
                   condition=3;
                   
               }
               else if(result[iindex-1,jindex]!=0)
               {
                   condition=3;
                   
                   
               }else
               {
                   result[iindex--,jindex]=value++;
               }
               
           }
           if(condition==3)
           {
               if(jindex==0)
               {
                   condition=0;
                  
               }
               else if(result[iindex,jindex-1]!=0)
               {
                   condition=0;
                  
                   
               }else
               {
                   result[iindex,jindex--]=value++;
               }
               
           }
           
        }
        
        result[iindex,jindex]=value++;
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
}

