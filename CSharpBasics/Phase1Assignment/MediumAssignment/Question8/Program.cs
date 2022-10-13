using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        string newString="";
        foreach(char value in word)
        {
            if(value>='0' && value<='9')
            {
                newString=newString+value;
            }
        }
        System.Console.WriteLine(newString);
        int number=int.Parse(newString);
        if(number%2==0)
        {
            System.Console.WriteLine("The Number is Even");
        }
        else
        {
            System.Console.WriteLine("The Number is Odd");
        }
    }
}