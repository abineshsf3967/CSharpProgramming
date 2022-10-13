using System;
namespace MeterConversion;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the meter value: ");
        double meter = double.Parse(Console.ReadLine());
        double centimeter = meter*100;
        double millimeter = centimeter*10;
        double inch = 39.3*meter;
        double foot = 12*meter;
        double mile = 0.0006213715277778*meter;
        System.Console.WriteLine("CM = "+centimeter);
        System.Console.WriteLine("Mm = "+millimeter);
        System.Console.WriteLine("Inch = "+inch);
        System.Console.WriteLine("foot = "+Math.Round(foot,2));
        System.Console.WriteLine("Mile = "+Math.Round(mile,2));
    }
}