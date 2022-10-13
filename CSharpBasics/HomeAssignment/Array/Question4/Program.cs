using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int range=int.Parse(Console.ReadLine());
        int[] numbers=new int[range];
        for(int index=0;index<numbers.Length;index++)
        {
            System.Console.WriteLine($"enter the array value {index+1}");
            numbers[index]=int.Parse(Console.ReadLine());
        }
        int value=numbers[0];
        for(int i=0;i<numbers.Length;i++)
        {
           if(numbers[i]>value)
           {
             value=numbers[i];
           }

        }
        System.Console.WriteLine("maximum : "+value);
        int value1=numbers[0];
        for(int i=0;i<numbers.Length;i++)
        {
            if(numbers[i]<value1)
            {
                value=numbers[i];
            }
        }
        System.Console.WriteLine("minimum : "+value1);
    }
}