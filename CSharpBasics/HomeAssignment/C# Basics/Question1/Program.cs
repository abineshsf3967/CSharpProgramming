using System;
namespace HelloName;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the name: ");
        string name = Console.ReadLine();
        System.Console.Write("Enter Hello: ");
        string hello = Console.ReadLine();
        
        //concatenation
        
        System.Console.WriteLine(hello+": "+name);

        // Place Holder

        System.Console.WriteLine("{0}: {1}",hello,name);

        //interpolation

        System.Console.WriteLine($"{hello}: {name}");
        
    }
}