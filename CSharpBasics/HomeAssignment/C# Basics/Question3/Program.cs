using System;
namespace Temperature;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the amount of Celsius: ");
        double celsius = float.Parse(Console.ReadLine());
        double kelvin = celsius+273.15;
        double fahrenheit = (celsius*9/5)+32;
        System.Console.WriteLine("Kelvin = "+kelvin);
        System.Console.WriteLine("Fahrenheit="+fahrenheit);
    }
}