using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date dd/MM/yyyy format: ");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("The formated date is: "+date.ToString("dd/MM/yyyy"));
        DateTime date2=DateTime.Now;
       if(date.ToString("dd/MM/yyyy")==date2.ToString("dd/MM/yyyy"))
       {
        System.Console.WriteLine("The current date status: TRUE");
       }
       else
       {
        System.Console.WriteLine("The current date status: FALSE");
       }
        
    }
}