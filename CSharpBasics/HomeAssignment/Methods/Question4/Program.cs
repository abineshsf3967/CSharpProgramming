using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first value: ");
        int firstValue=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second value: ");
        int secondValue=int.Parse(Console.ReadLine());
        Fibonacci(firstValue,secondValue);


        void Fibonacci(int value1,int value2)
        {
            System.Console.WriteLine("Enter the range: ");
            int range=int.Parse(Console.ReadLine());
            int count=2;
            System.Console.Write(value1+" "+value2);
            for(int i=0;count<range;i++)
            {
                int value3=value1+value2;
                System.Console.Write(" "+value3);
                value1=value2;
                value2=value3;
                count++;
            }

        }




    }
}