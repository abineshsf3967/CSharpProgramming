using System;
namespace Vote;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age>=18)
        {
            System.Console.WriteLine("Congratulation! \n You are eligible for casting your vote");
        }
        else
        {
            System.Console.WriteLine("Your not eligible for voting");
        }
    }
}
