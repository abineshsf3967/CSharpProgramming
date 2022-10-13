using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        System.Console.WriteLine("enter the extraction: ");
        int extraction=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter the substring: ");
        int substring=int.Parse(Console.ReadLine());
        for(int i=0;i<word.Length;i++)
        {
            if(i==extraction)
            {
                for(int j=extraction;j<extraction+substring;j++)
                {
                    System.Console.WriteLine(word[j]);
                }
            }
        }
    }
}