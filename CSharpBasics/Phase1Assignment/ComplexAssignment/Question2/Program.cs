using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int count=0;
        double total = 0;
        for(int i=0;i<=range;i++)
        {
            total+=(double)Power(count)/Factorial(count);
            count++;
        }
        System.Console.WriteLine();
        System.Console.WriteLine("SUM: "+total);


        double Power(double number)
        {
             int result=1;
             while(number>0)
             {
                result=result*2;
                number--;
             }
             return result;
        }

        int Factorial(int number1)
        {
            int fact=1;
            while(number1>0)
            {
               fact=fact*number1;
               number1--;
            }
            return fact;
        }
    }
}