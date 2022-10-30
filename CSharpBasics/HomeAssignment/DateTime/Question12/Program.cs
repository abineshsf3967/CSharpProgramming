using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month: ");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the year");
        int year=int.Parse(Console.ReadLine());
        int days=DateTime.DaysInMonth(year,month);
        System.Console.WriteLine("No of days in the month: "+days);
    }
}
