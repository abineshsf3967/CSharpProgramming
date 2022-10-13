using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
        string condition="";
        do
        {
             System.Console.WriteLine("Enter the input number: ");
             int input = int.Parse(Console.ReadLine());
            if(input%2==0)
            {
                System.Console.WriteLine("Even number");
            }
            else
            {
                System.Console.WriteLine("Odd number");
            }
            System.Console.WriteLine("If you want check another number: ");
             condition = Console.ReadLine().ToLower();
             if(condition!="yes" && condition!="no")
             {
                 System.Console.WriteLine("Invalid Option");
             break;
             }
        }while(condition=="yes");
       
    }
}