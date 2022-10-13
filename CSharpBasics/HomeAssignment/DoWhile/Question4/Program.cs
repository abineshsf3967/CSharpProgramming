using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int temp=0;
        string condition="";
        do
        {
            System.Console.WriteLine("Enter the number: ");
            int number;
            bool input=int.TryParse(Console.ReadLine(),out number);
                while(input==true)
                {
                   if(number>0 && number<=10)
                   {
                     System.Console.WriteLine("The given number is valid: "+number);
                     temp=1;
                   }
                   break;
                    
                }
                if(temp!=1)
                {
                    System.Console.WriteLine("The given number is invalid");
                }
                System.Console.WriteLine("You want enter another number: \n yes or \n no"); 
                condition=Console.ReadLine().ToLower();
        }while(condition=="yes");
    }
}
