using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        DateTime[] dates = { DateTime.Now, new DateTime(2016, 8, 16, 9, 28, 0),new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
        foreach(DateTime check in dates)
        {
            System.Console.WriteLine($"Day:{check.ToString("MM/dd/yyyy")} Time:{check.ToString("HH:mm:ss:ms")}");
            System.Console.WriteLine($"Day:{check.ToString("MM/dd/yyyy")} Time:{check.ToString("hh:mm tt ")}");
            System.Console.WriteLine();
        }


    }
}