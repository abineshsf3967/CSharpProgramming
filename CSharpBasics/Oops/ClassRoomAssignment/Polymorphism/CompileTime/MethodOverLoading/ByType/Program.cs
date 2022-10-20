using System;
namespace ByType;
class Program
{
    static void Display(int number)
    {
        System.Console.WriteLine("Argument: "+number);
    }
    static void Display(double number)
    {
        System.Console.WriteLine("Argument: "+number);
    }
    public static void Main(string[] args)
    {
        Display(20.10);
        Display(10);
    }
}
