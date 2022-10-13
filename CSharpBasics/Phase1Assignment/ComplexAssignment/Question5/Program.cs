using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date 1: dd/MM/yyyy hh:mm:ss");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy hh:mm:ss"),null);
         System.Console.WriteLine("Enter the date 2: dd/MM/yyyy");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy hh:mm:ss"),null);
        TimeSpan newdate=date1-date2;
        System.Console.WriteLine("Number of days inbetween: "+newdate.Days);
        System.Console.WriteLine("Number of hours inbetween: "+newdate.Hours);
        System.Console.WriteLine("Number of minutes inbetween: "+newdate.Minutes);
        System.Console.WriteLine("Number of seconds inbetween: "+newdate.Seconds);
    }
}