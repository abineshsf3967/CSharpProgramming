using System;
namespace Question15;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int value;
        for(value=2;value<=number;value++)
        {
            if(number%value==0)
            break;
        }
        if(number==value)
        {
            System.Console.WriteLine("It is prime number");
        }
        else
        {
            System.Console.WriteLine("It is not prime number");
        }
    }
}