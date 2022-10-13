using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string 1: ");
        string word1=Console.ReadLine();
        System.Console.WriteLine("Enter the string 2: ");
        string word2=Console.ReadLine();
        char[] word1Char=word1.ToCharArray();
        char[] word2Char=word2.ToCharArray();
        int count=0;
        int flag=1;
        if(word1.Length==word2.Length)
        {
            for(int i=0;i<word1.Length;i++)
            {
               for(int j=i+1;j<word1.Length;j++)
               {
                   if(word1Char[i]>word1Char[j])
                   {
                     char temp=word1Char[i];
                      word1Char[i]=word1Char[j];
                      word1Char[j]=temp;
                   }
               }
            }
            
            for(int i=0;i<word2.Length;i++)
            {
               for(int j=i+1;j<word2.Length;j++)
               {
                   if(word2Char[i]>word2Char[j])
                   {
                     char temp=word2Char[i];
                      word2Char[i]=word2Char[j];
                      word2Char[j]=temp;
                   }
               }
            }
            for(int i=0;i<word1.Length;i++)
            {
                if(word1Char[i]==word2Char[i])
                {
                    count++;
                }
                else
                {
                    System.Console.WriteLine("not anagram");
                    break;
                }
            }
          if(count==word1.Length)
          {
            System.Console.WriteLine("Anagram");
          }
          
        }
        else
        {
            System.Console.WriteLine("Not anagram");
        }
        
    }
}
