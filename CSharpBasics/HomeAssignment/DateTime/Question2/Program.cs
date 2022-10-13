using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
      
        Console.WriteLine(" Enter your date  dd/MM/yyyy hh:mm:ss tt format");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt", null);
        Console.WriteLine("Complete date: "+date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        Console.WriteLine("short date: "+date.ToString("MM/date/yyyy"));
        Console.WriteLine(date.ToLongDateString()+" "+date.ToString("hh:mm:ss tt"));
        Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("hh:mm:ss tt"));


    }
}