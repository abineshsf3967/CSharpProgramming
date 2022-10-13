using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0;
        string condition="";
        do
        {
            System.Console.WriteLine("Enter the number: ");
            int number=int.Parse(Console.ReadLine());
            sum=sum+number;
            System.Console.WriteLine("You want to enter another number: \n (yes) or \n (no) ");
             condition = Console.ReadLine().ToLower();
        }while(condition=="yes");
        System.Console.WriteLine("Sum of numbers: "+sum);
    }
}