using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the day: ");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
        System.Console.WriteLine($"Tommorrow: {date.AddDays(1).ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Yesterdays: {date.AddDays(-1).ToString("dd/MM/yyyy")}");
    }
}
