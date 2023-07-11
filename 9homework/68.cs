
using System;
class HelloWorld 
{
    static void Main() 
    {
        int a=Prompt("введите a\n");
        int b=Prompt("\nвведите b\n");
        int n=Prompt("\nвведите n\n");
        Console.WriteLine($"{phi(a,b,n)}");
    }
    static int alpha(int a,int n)
    {
        if(n==0)
        {
            return 0;
        }
        if(n==1)
        {
            return 1;
        }
        return a;
        
    }
    static int phi(int a,int b,int n)
    {
        if(n==0)
        {
           return a+b;
        }
        if(b==0)
        {
            return alpha(a,n-1);
        }
        return phi(a,phi(a,b-1,n),n-1);
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}