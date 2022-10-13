using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your date  dd/MM/yyyy hh:mm:ss tt format");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt", null);
        Console.WriteLine("Year="+date.Year);
        Console.WriteLine("Month="+date.Month);
        Console.WriteLine("Day="+date.Day);
        Console.WriteLine("Hour="+date.Hour);
        Console.WriteLine("Minute="+date.Minute);
        Console.WriteLine("Second="+date.Second);
    }
}
