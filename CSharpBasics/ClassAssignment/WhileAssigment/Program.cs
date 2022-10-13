using System;
namespace WhileAssigment;
class Program
{
    public static void Main(string[] args)
    {
        int input = 1;
        System.Console.WriteLine("Even number: ");
        while(input<=25)
        {
             if(input%2==0)
             {
                System.Console.WriteLine(input);
             }
             input++;
        }

        System.Console.WriteLine("Enter the number: ");
        int number;
        bool input1 = int.TryParse(Console.ReadLine(),out number);
        while(input1==false)
        {
             System.Console.WriteLine("Invalid input");
             System.Console.WriteLine("please enter the valid input in number format: ");
             input1 = int.TryParse(Console.ReadLine(),out number); 
        }
        System.Console.WriteLine("Valid number");
        
    }
}