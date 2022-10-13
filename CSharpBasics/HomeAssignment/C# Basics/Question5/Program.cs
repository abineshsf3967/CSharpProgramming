using System;
namespace MarksCalculation;
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
        float percentage = (((float)sumOfMarks/300))*100;
        System.Console.WriteLine("physics: "+physicsMark);
        System.Console.WriteLine("chemistry: "+chemistryMark);
        System.Console.WriteLine("maths: "+mathsMark);
        System.Console.WriteLine("Sum: "+sumOfMarks);
        System.Console.WriteLine("Percentage: "+percentage+"%");
    }
}