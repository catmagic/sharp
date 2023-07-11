using System;
class HelloWorld 
{
    static void Main() 
    {
        int m=Prompt("введите m\n");
        int n=Prompt("введите n\n");
        Console.WriteLine($"{rangeevenreverse(m,n)}");
    }
    static string rangeevenreverse(int start,int end)
    {
        if(start==end)
        {
            if(start%2==0)
            {
                return Convert.ToString(start);
            }
            return "";
        }
        if(end%2==1)
        {
            return rangeevenreverse(start,end-1);
        }
        return end+", "+rangeevenreverse(start,end-1);
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}