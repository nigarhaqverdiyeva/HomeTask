//using System;

//class Program
//{
//    static void Main()
//    {

//        double radius = 5;
//        double circleArea = CircleArea(radius);
//        Console.WriteLine("cevrenin sahesi"+ "- " +circleArea);

//        double length = 4;
//        double width = 6;
//        double rectangleArea = RectangleArea(length, width);
//        Console.WriteLine("duzbucaqlinin sahesi" + "- " + rectangleArea);

//        double height = 3;
//        double boxArea = BoxArea(length, width, height);
//        Console.WriteLine("duzbucaqli paralelipedin sahesi" + "- " + rectangleArea);

//        double a = 3;
//        double b = 4;
//        double c = 5;
//        double inscribedCircleArea = InscribedCircleArea(a, b, c);
//        Console.WriteLine("ucbucaqlinin daxiline çekilmiş çevrenin sahsi" + "- " + inscribedCircleArea);
//    }
//     static double CircleArea(double radius)
//    {
//        const double p = 3.0; 
//        return p * radius*radius;
//    }


//    static double RectangleArea(double length, double width)
//    {
//        return length * width;
//    }


//    static double BoxArea(double length, double width, double height)
//    {
//        return 2 * (length * width + length * height + width * height);
//    }

//    static double InscribedCircleArea(double a, double b, double c)
//    {
//        double p = (a + b + c);
//        double r = (2 * Area(a, b, c)) / p; 
//        return 3 * r;
//    }                                            ovveride


//using System;

//class Program
//{
//    static void Main()
//    {
//        int a = 10;
//        int b = 5;

//        Console.WriteLine(Add(a,b));
//    }

//    static int Add(int a, int b)
//    {
//        return a + b;
//    }
//}                                                   a varianntı

//using System;
//class Program
//{
//    static void Main()
//    {
//        int a = 3;
//        int b = 3;
//        Console.WriteLine(Power(a)); 
//        Console.WriteLine(Power(a,b)); 
//    }

//    static int Power(int a)
//    {
//        return a * a;
//    }

//    static int Power(int a, int b)
//    {
//        int d = 1;
//        for (int i = 1; i <= b; i++)
//        {
//            d = d *= a;

//        }
//            return d;
//    }
//}                                                      b varianti


//using System;

//class Program
//{
//    static void Main()
//    {
//        string name = "Nigar";
//        string lastName = "Hagverdiyeva";
//        string fatherName = "Arzu";

//        Method(name);
//        Method(lastName, name);
//        Method(lastName, name, fatherName);
//    }

  
//    static void Method(string name)
//    {
//        Console.WriteLine(name);
//    }

 
//    static void Method(string lastName, string name)
//    {
//        Console.WriteLine(lastName +" " + name);
//    }


//    static void Method(string lastName, string name, string fatherName)
//    {
//        Console.WriteLine(lastName[0]+ "."+ name+ " "+ fatherName);
//    }
//}                                                      c varianti
