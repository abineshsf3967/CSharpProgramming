using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        char[] wordChar=word.ToCharArray();
        string newString="";
        for(int index=0;index<wordChar.Length;index++)
        {
            for(int index2=index+1;index2<wordChar.Length;index2++)
            {
                if(wordChar[index]==wordChar[index2])
                {
                    wordChar[index2]='0';
                }
            }
        }
        foreach(char check in wordChar)
        {
            if(check!='0')
            {
                newString+=check;
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Output: "+newString);
    }
}