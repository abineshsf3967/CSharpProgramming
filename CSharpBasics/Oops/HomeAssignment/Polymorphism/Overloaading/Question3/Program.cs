using System;
namespace Question3;
class Pogram
{
    public static void Main(string[] args)
    {
        Square(2);
        Square(2.4);
        Square(2.345);
        Square(2345);
    }

    public static void Square(int number)
    {
        System.Console.WriteLine("Square: "+number*number);
    }

    public static void Square(float number)
    {
        System.Console.WriteLine("Square: "+number*number);
    }

    public static void Square(double number)
    {
        System.Console.WriteLine("Square: "+Math.Round(number*number,2));
    }

    public static void Square(long number)
    {
        System.Console.WriteLine("Square: "+number*number);
    }
}
