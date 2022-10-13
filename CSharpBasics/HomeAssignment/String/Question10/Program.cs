using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the user name: ");
        string userName=Console.ReadLine();
        System.Console.WriteLine("Enter the password: ");
        string password=Console.ReadLine();
        string check=password;
        if(check==password)
        {
            System.Console.WriteLine("Password entered successfully!");
        }
    }
}