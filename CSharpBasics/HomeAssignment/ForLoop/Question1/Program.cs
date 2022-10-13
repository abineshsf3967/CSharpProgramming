using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range = Convert.ToInt32(Console.ReadLine());
        for(int value=1;value<=range;value++)
        {
            System.Console.Write(value);
        }
    }
}