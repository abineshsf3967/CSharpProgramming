using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range = Convert.ToInt32(Console.ReadLine());
        for(int value=1;value<=range;value++)
        {
            int cube=(value*value*value);
            System.Console.WriteLine($"Number is: {value} and cube of the {value} is : {cube}");
            cube=0;
        }
    }
}