using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your year1  dd/MM/yyyy  format");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        //int start = date.Year;
       // System.Console.WriteLine(start);
        Console.WriteLine(" Enter your year2 dd/MM/yyyy   format");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        //int end= date1.Year;
        TimeSpan lastDate=date-date1;
        System.Console.WriteLine($"{date.ToString("dd/MM/yyyy")}: day{lastDate.Days} of {date.Year}");
       
    }
}
