using System;
namespace TotalAmount;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the price amount of product: ");
        int priceAmount = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("The tax of the product is 18%");
        double total = priceAmount+(priceAmount*0.18);
        System.Console.WriteLine("Total= "+total);
    }
}