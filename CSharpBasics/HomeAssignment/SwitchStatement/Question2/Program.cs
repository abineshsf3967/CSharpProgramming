using System;
namespace Day;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Choice anyone Option given below: \n 1.Monday \n 2.Tuesday \n 3.Wednesday  \n 4.Thursday \n 5.Friday  \n 6.Saturday \n 7.Sunday");
        System.Console.WriteLine("Enter the option: ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
                   {
                    System.Console.WriteLine("Monday");
                   }
                   break;
            case 2:
                   {
                    System.Console.WriteLine("Tuesday");
                   }
                   break;
            case 3:
                   {
                    System.Console.WriteLine("Wednesday");
                   }              
                   break;
            case 4:
                   {
                    System.Console.WriteLine("Thursday");
                   }       
                   break;
            case 5:
                   {
                    System.Console.WriteLine("Friday");
                   }       
                   break;
            case 6:
                   {
                    System.Console.WriteLine("Saturday");
                   }       
                   break;
            case 7:
                   {
                    System.Console.WriteLine("Sunday");
                   }       
                   break;
            default :
                   {
                    System.Console.WriteLine("Invalid Option");
                   }
                   break;
        }
    }
}