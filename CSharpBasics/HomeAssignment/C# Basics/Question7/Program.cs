using System;
namespace Equation;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the a value: ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the b value: ");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("equation: (a+b)^2=a^2+2ab+b^2");
        int output = (a*a)+(2*a*b)+(b*b);
        System.Console.WriteLine("output = "+output);
    }
}