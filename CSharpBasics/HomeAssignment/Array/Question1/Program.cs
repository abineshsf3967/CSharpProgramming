using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int[] numbers=new int[5];
        for(int intial=0;intial<numbers.Length;intial++ )
        {
            System.Console.WriteLine($"Enter the array value {intial+1}");
           numbers[intial]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Output: ");
        for(int intial=0;intial<numbers.Length;intial++)
        {
            System.Console.Write(numbers[intial]+" ");
        }
    }
}
