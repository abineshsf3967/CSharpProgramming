using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first date: ");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
        System.Console.WriteLine("Enter the second date: ");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
        int result=DateTime.Compare(date1,date2);
        if(result<0)
        {
            System.Console.WriteLine($"{date1.ToString("dd/MM/yyyy")} is earlier than {date2.ToString("dd/MM/yyyy")}");
        }
        else if(result==0)
        {
            System.Console.WriteLine($"{date1.ToString("dd/MM/yyyy")} is equalto {date2.ToString("dd/MM/yyyy")}");
        }
        else
        {
            System.Console.WriteLine($"{date2.ToString("dd/MM/yyyy")} is earlier than {date1.ToString("dd/MM/yyyy")}");
        }
    }
}
