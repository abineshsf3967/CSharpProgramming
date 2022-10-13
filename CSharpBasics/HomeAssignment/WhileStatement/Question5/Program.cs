using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        int sum=0;
        while(number>0)
        {
            int remainder=number%10;
            sum=sum+remainder;
            number/=10;
        }
        System.Console.WriteLine("Sum of digits: "+sum);
    }
}
