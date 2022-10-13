using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int[] numbers=new int[range];
        for(int index=0;index<numbers.Length;index++)
        {
            System.Console.WriteLine($"Enter the array value {index+1}");
            numbers[index]=int.Parse(Console.ReadLine());
        }
        int sum=0;
        foreach(int check in numbers)
        {
            sum+=check;
        }
        System.Console.WriteLine("sum of array elements: "+sum);
    }
}