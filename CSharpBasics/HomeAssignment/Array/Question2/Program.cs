using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int[] numbers=new int[range];
        for(int index=0;index<range;index++)
        {
            System.Console.WriteLine($"Enter the array value {index+1}");
             numbers[index]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("The values in the given array: ");
        foreach(int check in numbers)
        {
            System.Console.Write(" "+check);
        }
        
        System.Console.WriteLine("\n The reverse of array: ");
        for(int index=numbers.Length-1;index>=0;index--)
        {
            System.Console.Write(" "+numbers[index]);
        }
    }
}