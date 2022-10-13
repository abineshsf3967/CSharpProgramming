using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Start Number: ");
        int startNumber = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the range:");
        int range = int.Parse(Console.ReadLine());
        System.Console.WriteLine("output:");
        while(startNumber>=0)
        {
            if(startNumber>=range)
            {
            System.Console.WriteLine(startNumber);
            }
            startNumber++;
        }
        System.Console.WriteLine("Invalid Number");
    }
}
