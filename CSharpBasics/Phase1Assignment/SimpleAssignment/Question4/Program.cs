using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the cuurency as rate(INR): ");
        double inr=double.Parse(Console.ReadLine());
        double usd=(inr*0.0122);
        double eur=(inr*0.0127);
        double cny=(inr*0.0879);
        System.Console.WriteLine("INR to USD: "+(decimal)usd);
        System.Console.WriteLine("INR to EUR: "+(decimal)eur);
        System.Console.WriteLine("INR to CNY: "+(decimal)cny);
    }
}
