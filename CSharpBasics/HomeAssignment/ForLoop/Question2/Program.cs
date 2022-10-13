using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        double average;
        for(int value=1;value<=range;value++)
        {
            sum+=value;
        }
        average=(double)sum/range;
        System.Console.WriteLine("Sum: "+sum);
        System.Console.WriteLine("Average: "+average);
    }
}