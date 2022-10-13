using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Input Number: ");
        int input=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("The odd Numbers are: ");
        int sum=0;
        int count=0;
           for(int value=1;count<input;value++)
           {
              if(value%2!=0)
              {
                System.Console.Write(value);
                count++;
                sum+=value;
              }
            }
        System.Console.WriteLine($"Sum of Odd number upto {input} terms : {sum}");
    }
}