using System;
namespace MethodsAssignments;
class Programs
{
    public static void Main(string[] args)
    {   
        string condition;
        do
        {
        System.Console.WriteLine("Choose anyone option given below: \n1.Addition \n 2.Subtraction \n3.Multiplication \n4.Division ");
        int input = int.Parse(Console.ReadLine());
        switch(input)
        {
            case 1:
                   {
                    System.Console.WriteLine("enter the value1: ");
                    int value1=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("enter the value2: ");
                    int value2=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Sum of number: "+Addition(value1,value2));
                   }
                   break;
            case 2:
                  {
                     System.Console.WriteLine("enter the value1: ");
                    int value1=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("enter the value2: ");
                    int value2=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("subtraction of number: "+Subtraction(value1,value2));
                  }     
                  break;
            case 3:
                   {
                     System.Console.WriteLine("enter the value1: ");
                    int value1=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("enter the value2: ");
                    int value2=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Multiply of number: "+Multiplication(value1,value2));
                   }        
                   break;
            case 4:
                   {
                     System.Console.WriteLine("enter the value1: ");
                    int value1=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("enter the value2: ");
                    int value2=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("division of number: "+Division(value1,value2));
                   }       
                   break;
            default:
                    {
                        System.Console.WriteLine("Invalid option");
                    }       
                    break;
        }
        System.Console.WriteLine("you wants to continue: ");
        condition=Console.ReadLine().ToLower();
        }while(condition=="yes");


        //Addition
        int Addition(int number1,int number2)
        {
            return (number1+number2);
        }

        //Subtraction
        int Subtraction(int number1,int number2)
        {
            return (number1-number2);
        }

        //Multiplication

        int Multiplication(int number1,int number2)
        {
            return (number1*number2);
        }

        //Division

        int Division(int number1,int number2)
        {
            return (number1/number2);
        }

    }
}