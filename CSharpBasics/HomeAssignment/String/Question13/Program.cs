using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string word=Console.ReadLine();
        int sum=0;
        foreach(char check in word)
         {
            if(check>='0' && check<='9')
            {
                int value=(int)char.GetNumericValue(check);
                sum=sum+value;
            }
         }
         System.Console.WriteLine("sum : "+sum);
    }
}