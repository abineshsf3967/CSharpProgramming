using System;
namespace Admission;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the physics mark: ");
        int physicsMark = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the chemistry mark: ");
        int chemistryMark = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the maths mark: ");
        int mathsMark = Convert.ToInt32(Console.ReadLine());
        int sumOfMarks = physicsMark+chemistryMark+mathsMark;
        float percentage = ((float)sumOfMarks/300)*100;
        if(percentage>=75)
        {
            System.Console.WriteLine("The candidate is eligible for admission");
        }
        else
        {
           System.Console.WriteLine("The candidate is Not eligible for admission");
        }
    }
}
