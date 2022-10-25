using System;
namespace Question2;
class Program
{
    public static void Result (int number)
    {
        System.Console.WriteLine("number: "+number);
    }

    public static void Result(int number1,int number2)
    {
        System.Console.WriteLine($"number1:{number1}  |number2:{number2}");
    }

    public static void Result(int number1,int number2,int number3)
    {
        System.Console.WriteLine($"number1:{number1}  |number2:{number2}  |number3:{number3}");
    }

    public static void Result(double number1,double number2)
    {
        System.Console.WriteLine($"number1:{number1}   |number2:{number2}");
    }

    public static void Result(int number1,double number2,double number3)
    {
        System.Console.WriteLine($"number1:{number1}     |number2:{number2}    |number3:{number3}");
    }

    public static void Main(string[] args)
    {
        Result(10);
        Result(10,20);
        Result(10,20,30);
        Result(20.30,30.30);
        Result(4,4.5,44.5);
    }
}
