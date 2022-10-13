using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("select anyone operator given below: \n + \n - \n * \n / \n %");
        char operation = Convert.ToChar(Console.ReadLine());
        switch(operation)
        {
            case '+':
                     {
                        System.Console.WriteLine("result value: "+(firstNumber+secondNumber));
                     }
                     break;
            case '-':
                    {
                        System.Console.WriteLine("result value:"+(firstNumber-secondNumber));
                    }         
                    break;
            case '*':
                     {
                        System.Console.WriteLine("result value: "+(firstNumber*secondNumber));
                     }   
                     break;
            case '/':
                     {
                        System.Console.WriteLine("result value: "+((float)firstNumber/secondNumber));
                     }     
                     break;
            case '%':
                     {
                        System.Console.WriteLine("result value: "+(firstNumber%secondNumber));
                     }    
                     break;
            default :
                    {
                        System.Console.WriteLine("Operation Invalid");
                    }  
                    break;                     
        }
    }
}