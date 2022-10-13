using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the starting number:  ");
        int start=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the difference: ");
        int difference=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int count=start,sum=0;
        for(int i=1;i<=range;i++)
        {
            System.Console.Write(count+" ");
            sum=sum+count;
            count=count+difference;
        }
        System.Console.WriteLine();
        System.Console.WriteLine(sum);
    }
}
