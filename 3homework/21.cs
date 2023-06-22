
using System;
class HelloWorld {
    class Point
    {
        public int x{get;set;}
        public int y{get;set;}
        public int z{get;set;}
        
    }
  static void Main() {
      Point A=new Point();
      Point B=new Point();
      A.x=getNumber("введите x компоменту первой точки");
      A.y=getNumber("введите y компоменту первой точки");
      A.z=getNumber("введите z компоменту первой точки");
      B.x=getNumber("введите x компоменту второй точки");
      B.y=getNumber("введите y компоменту второй точки");
      B.z=getNumber("введите z компоменту второй точки");
      Console.WriteLine($"дистанция между точками{distanse(A,B)}");
  
  }
  
  static int getNumber(string s)
  {
      Console.WriteLine(s);
      return Convert.ToInt32(Console.ReadLine());
  }

  static double distanse(Point A,Point B)
  {
      return Math.Sqrt(Math.Pow((A.x-B.x),2)+Math.Pow((A.y-B.y),2)+Math.Pow((A.z-B.z),2));
  }
}
