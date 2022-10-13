using System;
namespace LeapYear;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if(year%400==0)
        {
            System.Console.WriteLine(year+" is a leap year");
        }
        else if(year%100==0)
        {
            System.Console.WriteLine(year+" is not a leap year");
        }
        else if(year%4==0)
        {
            System.Console.WriteLine(year+" is a leap year");
        }
        else
        {
           System.Console.WriteLine(year+" is not leap year");
        }
    }
}