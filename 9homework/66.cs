using System;
class HelloWorld 
{
    static void Main() 
    {
        int m=Prompt("введите m\n");
        int n=Prompt("введите n\n");
        Console.WriteLine($"{sumrange(m,n)}");
    }
    static int sumrange(int start,int end)
    {
        if(start==end)
        {
            return start;
        }
        return start+sumrange(start+1,end);
    }
    static int Prompt(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
}