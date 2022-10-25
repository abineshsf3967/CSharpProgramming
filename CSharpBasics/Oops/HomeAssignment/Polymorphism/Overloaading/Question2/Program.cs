using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Square(2);
        Square(2,4);
        Square(2,4,6);
        Square(2.4,4.3);
        Square(4.8,10.8,5.6);
    }
    public static void Square(int number)
    {
        int square=number*number;
        System.Console.WriteLine("Square Value: "+square);
    }

    public static void Square (int number1,int number2)
    {
        int multiplication=number1*number2;
        System.Console.WriteLine("Multiplication: "+multiplication);
    }

    public static void Square(int number1,int number2,int number3)
    {
        int multiplication=number1*number2*number3;
        System.Console.WriteLine("Multiplication: "+multiplication);
    }


    public static void Square(double number1,double number2)
    {
        double multiplication=number1*number2;
        System.Console.WriteLine("Multiplicattion: "+Math.Round(multiplication,2));
    }

    public static void Square(double number1,double number2,double number3)
    {
        double multiplication=number1*number2*number3;
        System.Console.WriteLine("Multiplication: "+multiplication);
    }
}