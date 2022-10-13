using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        System.Console.WriteLine("Reverse string: ");
        for(int i=word.Length-1;i>=0;i--)
        {
            System.Console.Write(word[i]+" ");
        }
    }
}