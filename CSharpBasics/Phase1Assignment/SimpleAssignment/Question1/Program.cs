using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the inches: ");
        double number1=double.Parse(Console.ReadLine());
        double output=number1*2.54;
        System.Console.WriteLine($"The conversion of {number1} inches to centimeter {output} cm");
    }
}