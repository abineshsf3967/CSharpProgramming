using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first string: ");
        string word1=Console.ReadLine();
        System.Console.WriteLine("Enter the second string: ");
        string word2=Console.ReadLine();
        int count=0;
        if(word1.Length==word2.Length)
        {
            for(int i=0;i<word1.Length;i++)
            {
                if(word1[i]==word2[i])
                {
                    count++;
                }
                else
                {
                    System.Console.WriteLine("NOT EQUAL");
                    break;
                }
            }
        }
        else
        {
            System.Console.WriteLine("The both strings are not equal");
        }
        if(count==word1.Length)
        {
            System.Console.WriteLine("The lenght of both strings are equal and also both strings are equal");
        }
    }
}