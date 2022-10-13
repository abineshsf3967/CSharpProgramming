using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        string[] newWord=new string[word.Length];
        int count=0;
        for(int i=0;i<word.Length;i++)
        {
            if(word[i]==' ')
            {
                 count++;
            }
        }
        System.Console.WriteLine("Number of strings in sentence: "+(count+1));
    }
}