using System;
namespace AcceptGrade;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter anyone grade mentioned below: \n E - Excellent \n V-Very Good  \n G-Good \n A-Average \n F-Fail ");
        System.Console.WriteLine("enter your Grade: ");
        char grade = Convert.ToChar(Console.ReadLine().ToUpper());
        switch(grade)
        {
            case 'E':
                     {
                        System.Console.WriteLine("Excellent");
                     }
                     break;
            case 'V':
                     {
                        System.Console.WriteLine("Very Good");
                     }
                     break;
            case 'G':
                     {
                        System.Console.WriteLine("Good");
                     }
                     break;
            case 'A':
                     {
                        System.Console.WriteLine("Average");
                     }
                     break;
            case 'F':
                     {
                        System.Console.WriteLine("Fail");
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
