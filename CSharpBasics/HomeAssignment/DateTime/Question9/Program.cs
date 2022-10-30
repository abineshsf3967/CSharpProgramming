using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        for(int i=1994;i<=2014;i++)
        {
            bool result=DateTime.IsLeapYear(i);
            if(result)
            {
                System.Console.WriteLine($"{i} is leap year");
                DateTime date=new DateTime(i,02,29);
                System.Console.WriteLine($"{date.ToString("dd/MM/yyyy")} after a year {date.AddYears(1).ToString("dd/MM/yyyy")} ");
            }
        }
    }
}
