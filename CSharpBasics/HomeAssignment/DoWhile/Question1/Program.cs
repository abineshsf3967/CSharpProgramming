using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string choice="";
        do
        {
            System.Console.WriteLine("Enter the number: ");
            int input = int.Parse(Console.ReadLine());
            if(input%2!=0)
            {
                System.Console.WriteLine("The given number is odd number");
            }
            else
            {
                System.Console.WriteLine("The given number is even number");
            }
            System.Console.WriteLine("enter the user choice: \n yes \n no");
             choice=Console.ReadLine().ToLower();
        }while(choice=="yes");       
    }
}