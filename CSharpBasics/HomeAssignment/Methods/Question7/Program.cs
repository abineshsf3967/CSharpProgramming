using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int check=0;
        System.Console.WriteLine("Enter the word: ");
        string word=Console.ReadLine();
        bool get=palindrome(word,check);
        if(get==true)
        {
            System.Console.WriteLine("word is palindrome");
        }
        else
        {
            System.Console.WriteLine("Not palindrome");
        }


        bool palindrome(string word,int check)
        {
            if(check>word.Length/2)
            {
                return true;
            }
            return ( word[check]==word[word.Length-check-1] && palindrome(word,check+1));
        }
        
    }
}