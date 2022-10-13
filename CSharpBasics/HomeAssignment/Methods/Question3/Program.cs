using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input 1: ");
        int input1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the input 2: ");
        int input2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Before swap: ");
        System.Console.WriteLine($"{input1} \t {input2}");
        swap(input1,input2);


        void swap(int number1,int number2)
        {
            int temp=number1;
            number1=number2;
            number2=temp;
            System.Console.WriteLine("after swap: ");
            System.Console.WriteLine($"{number1} \t {number2}");
        }
    }
}
