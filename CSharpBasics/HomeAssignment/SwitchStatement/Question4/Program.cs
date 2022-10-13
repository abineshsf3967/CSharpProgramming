using System;
namespace Operation;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Input 1: ");
        int input1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Input 2: ");
        int input2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Choose anyone operation: \n1.Additon \n2.Subtraction \n3.Multiplication \n4.Division \n5.Exit");
        System.Console.WriteLine("Enter your option: ");
        int operation = Convert.ToInt32(Console.ReadLine());
        switch(operation)
        {
            case 1:
                {
                    System.Console.WriteLine("Output: "+(input1+input2));
                }
                break;
            case 2:
                {
                    System.Console.WriteLine("Output: "+(input1-input2));
                }
                break;    
            case 3:
                {
                    System.Console.WriteLine("Output: "+(input1*input2));
                }
                break;    
            case 4:
                {
                    System.Console.WriteLine("Output: "+(input1/input2));
                }
                break;    
            case 5:
                {
                    System.Console.WriteLine("Exit");
                }
                break;        
            default :
                  {
                    System.Console.WriteLine("Invalid Option");
                  }    
                  break;
        }
    }
}