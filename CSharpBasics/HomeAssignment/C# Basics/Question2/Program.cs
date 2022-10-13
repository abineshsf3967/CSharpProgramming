using System;
namespace ArithmeticOperator;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Input the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int addition = firstNumber+secondNumber;
        int subtraction = firstNumber-secondNumber;
        int multiplication = firstNumber*secondNumber;
        int division = firstNumber/secondNumber;
        int modulus = firstNumber%secondNumber;
        System.Console.WriteLine($"{firstNumber} + {secondNumber} = {addition}");
        System.Console.WriteLine($"{firstNumber} - {secondNumber} = {subtraction}");
        System.Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplication}");
        System.Console.WriteLine($"{firstNumber} / {secondNumber} = {division}");
        System.Console.WriteLine($"{firstNumber} % {secondNumber} = {modulus}");
    }
}