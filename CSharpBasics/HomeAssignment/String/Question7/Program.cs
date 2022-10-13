using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine().ToLower();
        int count=0,temp=0;
        for(int i=0;i<word.Length;i++)
        {
            if(word[i]=='a' || word[i]=='e' || word[i]=='i' || word[i]=='o' || word[i]=='u')
            {
                 count++;
            }
            else if(word[i]>='a' || word[i]>='z')
            {
                temp++;
            }
        }
        System.Console.WriteLine("The total number of vowels in strings: "+count);
        System.Console.WriteLine("The total number of constant in string: "+temp);
    }
}