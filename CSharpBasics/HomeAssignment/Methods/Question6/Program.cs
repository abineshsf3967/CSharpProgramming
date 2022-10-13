using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the factorial: ");
        int number=int.Parse(Console.ReadLine());
        Factorial(number);



        void Factorial(int number)
        {
            int fact=1;
            for(int i=1;i<=number;i++)
            {
               fact=fact*i;
            }
            System.Console.WriteLine("factorial: "+fact);
        }
    }
}
