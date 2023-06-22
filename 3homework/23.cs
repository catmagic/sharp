using System;
class HelloWorld {

  static void Main() {
      
      int N=getNumber("введите N");
      int []cubs=GetCubs(N);
      foreach(int cub in cubs)
      {
          Console.Write($"{cub} ");
      }
  
  }
  
  static int getNumber(string s)
  {
      Console.WriteLine(s);
      return Convert.ToInt32(Console.ReadLine());
  }
  static int[] GetCubs(int N)
  {
      int [] cub=new int[N];
      for(int i=0;i<N;++i)
      {
          cub[i]=(i+1)*(i+1)*(i+1);
      }
      return cub;
  }
  
}

