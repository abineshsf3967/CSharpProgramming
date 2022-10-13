using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Enter your year1  dd/MM/yyyy  format");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        int start = date.Year;
        System.Console.WriteLine(start);
        Console.WriteLine(" Enter your year2 dd/MM/yyyy   format");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);
        int end= date1.Year;
        for(int yyyy=start;yyyy<=end;yyyy++)
        {
            System.Console.WriteLine($"{date.ToString("MM/dd/yyyy")}");
        }//12/31/2001: day 365 of 2001 
        //($"Day:{check.ToString("MM/dd/yyyy")} Time:{check.ToString("hh:mm tt ")}");
        //.Add years
    }
}
