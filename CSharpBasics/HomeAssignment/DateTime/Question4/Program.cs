using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your date  dd/MM/yyyy hh:mm:ss tt format");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        Console.WriteLine(date.DayOfWeek);
    }
}
