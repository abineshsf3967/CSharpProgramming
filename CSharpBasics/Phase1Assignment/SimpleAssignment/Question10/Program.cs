using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the character: ");
        char check=char.Parse(Console.ReadLine().ToLower());
        if(check=='a' || check=='e' || check=='i' || check=='o' || check=='u')
        {
            System.Console.WriteLine("It is vowels");
        }
        else
        {
            System.Console.WriteLine("It is Not vowels");
        }
    }
}
