using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        int temp=0,count=0,value=0;
        for(int i=0;i<word.Length;i++)
        {
            int ascii=(int)word[i];
            System.Console.Write(" "+ascii);
            
            if( ascii>=65 && ascii<=90 ||  ascii>=97 && ascii<=122 )
            {
                temp++;
            }
            else if(ascii>=48 && ascii<=57)
            {
                count++;
            }
            else
            {
                value++;
            }
        }
        System.Console.WriteLine("Number of alphabets: "+temp);
        System.Console.WriteLine("Number of digits: "+count);
        System.Console.WriteLine("Number of special character: "+value);
    }
}