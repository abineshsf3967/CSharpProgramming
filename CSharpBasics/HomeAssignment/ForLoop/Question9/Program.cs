using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the the value: ");
        int value = Convert.ToInt32(Console.ReadLine());
        int temp=value;
        int sum=0;
        int count=0;
        for(int check=value;check>0;check=check/10)
        {
            count++;
        }
        for(int number=value;number>0;value++)
        {
            int reminder=number%10;
            sum=sum+(int)Math.Pow(reminder,count);
            number/=10;
        }
        if(temp==sum)
        {
            System.Console.WriteLine($"{temp} is an Armstrong number");
        }
        else
        {
            System.Console.WriteLine($"{temp} is an not Amstrong number");
        }
    }
}
