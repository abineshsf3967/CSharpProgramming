using System;
namespace Question6;
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
        for(int index=0;index<numbers.Length;index++)
        {
           for(int index1=index+1;index1<numbers.Length;index1++)
           {
            if(numbers[index]>numbers[index1])
            {
                int temp=numbers[index];
                numbers[index]=numbers[index1];
                numbers[index1]=temp;
            }
           }
        }
        System.Console.WriteLine("Ascending order:");
        for(int index=0;index<numbers.Length;index++)
        {
            System.Console.WriteLine(numbers[index]);
        }
    }
}
