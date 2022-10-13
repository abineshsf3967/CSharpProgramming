using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number: ");
        bool input = int.TryParse(Console.ReadLine(),out number);
        while(number>=0)
        {
            if(input==true && number<=5 )
            {
                System.Console.WriteLine("valid input");
                break;
            }
            System.Console.WriteLine("Invalid input enter again");
            System.Console.WriteLine("Enter the number: ");
             input = int.TryParse(Console.ReadLine(),out number);
        }
    }
}
