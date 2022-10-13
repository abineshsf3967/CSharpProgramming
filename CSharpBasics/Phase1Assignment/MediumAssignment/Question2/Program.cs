using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int number1=0;
        int number2=1;
        System.Console.Write(number1+" "+number2);
        int count=2;
        for(int start=1;start>=0;start++)
        {
               if(count<range)
               {
                int number3=number1+number2;
                System.Console.Write(" "+number3);
                number1=number2;
                number2=number3;
                count++;
               }
        }
    }
}
