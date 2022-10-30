using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date: ");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
        System.Console.WriteLine($"{date.ToString("dd/MM/yyyy")} before year {date.AddYears(-1).ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"{date.ToString("dd/MM/yyyy")} after year {date.AddYears(1).ToString("dd/MM/yyyy")}");
    }
}
