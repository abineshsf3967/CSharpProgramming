using System;
namespace FoorLoop;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Even number");
        for(int number=0;number<=25;number++)
        {
            if(number%2==0)
            {
                System.Console.WriteLine(number);
            }
        }
        System.Console.WriteLine("Enter the intialValue: ");
        int intialValue = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the finalValue: ");
        int finalValue = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int firstValue=intialValue;firstValue<=finalValue;firstValue++)
        {
            sum+=firstValue*firstValue;
        }
        System.Console.WriteLine("sum of numbers: "+sum);
    }
}