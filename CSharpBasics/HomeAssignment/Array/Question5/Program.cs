using System;
namespace Question5;
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
        System.Console.WriteLine("even elements: ");
        for(int index=0;index<numbers.Length;index++)
        {
            if(numbers[index]%2==0)
            {
                System.Console.WriteLine(numbers[index]);
            }
        }
        System.Console.WriteLine("odd elements: ");
        for(int index=0;index<numbers.Length;index++)
        {
            if(numbers[index]%2!=0)
            {
                System.Console.WriteLine(numbers[index]);
            }
        }
    }
}