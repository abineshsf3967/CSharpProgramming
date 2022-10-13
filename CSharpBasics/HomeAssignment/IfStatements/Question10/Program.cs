using System;
namespace Password;
class Program
{
    public static void Main(string[] args)
    {
        string defaultPassword = "HiTeam";
        System.Console.WriteLine("Enter the password : ");
        string input1 = Console.ReadLine();
        if(input1==defaultPassword)
        {
            System.Console.WriteLine("Right password");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
        
        System.Console.WriteLine("enter the password  :  ");
        string input2 = Console.ReadLine();
         if(input2==defaultPassword)
        {
            System.Console.WriteLine("Right password");
        }
       else
        {
            System.Console.WriteLine("Wrong password");
        }
        
    }
}