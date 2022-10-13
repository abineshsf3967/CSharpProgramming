using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the table to calculate: ");
        int table=int.Parse(Console.ReadLine());
        for(int value=1;value<=20;value++)
        {
            System.Console.WriteLine($"{table} * {value} = {table*value}");
        }
    }
}
