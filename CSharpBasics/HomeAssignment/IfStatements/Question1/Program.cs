using System;
namespace EvenOdd;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the test data: ");
        int value = Convert.ToInt32(Console.ReadLine());
        if(value%2==0)
        {
            System.Console.WriteLine(value+" is an even integer");
        }
        else
        {
           System.Console.WriteLine(value+" is an odd integer");
        }
    }
}
