using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        
        int startRange = 1;
        int sum=0;
        int count=0;
        System.Console.WriteLine("enter the series of number: ");
        int number = int.Parse(Console.ReadLine());
        for(int i=number;i>0;i=i/10)
        {
            count++;
        }
        while(startRange<=count)
        {
              int remainder = number%10;
              sum = sum+(int)Math.Pow(remainder,2);
              number/=10;
              startRange++;
        }
        System.Console.WriteLine("SUM: "+sum);
    }
}
