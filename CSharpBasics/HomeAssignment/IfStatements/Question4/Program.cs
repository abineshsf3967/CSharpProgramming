using System;
namespace LargestOfThree;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number: ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the second number: ");
        int value2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the third number: ");
        int value3 = Convert.ToInt32(Console.ReadLine());
        if((value1>value2) && (value1>value3))
        {
            System.Console.WriteLine("The 1st number is the greatest among three ");
        }
        else if((value2>value1) && (value2>value3))
        {
            System.Console.WriteLine("The 2nd number is the greatest among three");
        }
        else
        {
           System.Console.WriteLine("The 3rd number is the greatest among three");
        }
    }
}