using System;
namespace DateTimes;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dateTime=new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine("Year: "+dateTime.Year);
        System.Console.WriteLine("Month: "+dateTime.Month);
        System.Console.WriteLine("Day: "+dateTime.Day);
        System.Console.WriteLine("Hours: "+dateTime.Hour);
        System.Console.WriteLine("Minutes: "+dateTime.Minute);
        System.Console.WriteLine("Seconds: "+dateTime.Second); 
        System.Console.WriteLine();
        string dateTime1=dateTime.ToString("yyyy/MM/dd hh:mm:ss tt");
        string[] reverse=dateTime1.Split(new char[]{'/',' ',':'});
        System.Console.WriteLine("reverse: ");
        for(int i=reverse.Length-1;i>=0;i--)
        {
            System.Console.Write(" "+reverse[i]);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Enter the date time yyyy/MM/dd hh:mm:ss tt");
        DateTime input=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        System.Console.WriteLine(input.ToString("yyyy/MM/dd"));
    }
}