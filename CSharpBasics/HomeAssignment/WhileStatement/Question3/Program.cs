using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number: ");
        int secondNumber= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the terms: ");
        int terms = int.Parse(Console.ReadLine());
        int i=2,thirdNumber=0;
        System.Console.Write(firstNumber+"\t"+secondNumber);
        while(i<terms)
        {
            thirdNumber=firstNumber+secondNumber;
            System.Console.Write("\t"+thirdNumber);
            firstNumber=secondNumber;
            secondNumber=thirdNumber;
            i++;
        }
    }
}