using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        
         System.Console.WriteLine("Enter the number 1: ");
         int input1=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter the number 2: ");
         int input2=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Addition: "+Addition(input1,input2));
         System.Console.WriteLine("Subtraction: "+Subtraction(input1,input2));
         System.Console.WriteLine("Multiplication: "+Multiply(input1,input2));
         System.Console.WriteLine("Division: "+Divide(input1,input2));
         


        // addition
        int Addition(int number1,int number2)
        {
           int sum=number1+number2;
           return sum;
        }

        // subtraction
        int Subtraction(int number1,int number2)
        {
            int subtract=number1-number2;
           return subtract;
        }

        //multiplication
        int Multiply(int number1,int number2)
        {
             int multiply=number1*number2;
           return multiply;

        }

        //division
        int Divide(int number1,int number2)
        {
             int divide=number1/number2;
           return divide;
        }
    }
}
