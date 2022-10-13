using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the lower limit: ");
        int limit1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Upper limit: ");
        int limit2=int.Parse(Console.ReadLine());
        int count=0;
        System.Console.WriteLine("Amstrong number: ");
        for(int value=limit1;value<=limit2;value++)
        {
            int temp=value;
            for(int i=value;i>0;i=i/10)
            {
                count++;
            }
            int sum=0;
            while(value!=0)
            {
                int remainder=value%10;
                sum=sum+(int)Math.Pow(remainder,count);
                value/=10;
            }
            count=0;
            value=temp;
            if(temp==sum)
            {
                System.Console.WriteLine(temp);
            }
            
        }
    }
}