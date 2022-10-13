using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        int count=0;
        for(int i=0;i<word.Length;i++)
        {
            count++;
        }
        System.Console.WriteLine(count);
    }
}
