using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the degrees on celsius: ");
        double celsius=double.Parse(Console.ReadLine());
        double fahrenheit=(celsius*(9/5)+32);
        System.Console.WriteLine("Celsius to Fahrenheit: "+Math.Round(fahrenheit,2));
    }
}
