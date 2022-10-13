using System;
namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int sumOfSquares=0;
        for(int value=1;value<=99;value++)
        {
            if(value%2!=0)
            {
                 sumOfSquares+=(value*value);
            }
        }
        System.Console.WriteLine($"Sum of squares of odd number from 1 to {range}: {sumOfSquares}");
        
    }
}
