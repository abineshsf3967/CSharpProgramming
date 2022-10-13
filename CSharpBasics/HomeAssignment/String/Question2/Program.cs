using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        for(int i=0;i<word.Length;i++)
        {
            System.Console.Write(word[i]+" ");
        }
    }
}