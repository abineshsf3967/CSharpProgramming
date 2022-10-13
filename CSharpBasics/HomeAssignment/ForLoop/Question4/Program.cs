using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the table to calculate: ");
        int table = Convert.ToInt32(Console.ReadLine());
        for(int value=1;value<=10;value++)
        {
            System.Console.WriteLine($"{table} x {value} = {value*table}");
        }
    }
}
