using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the mark 1:");
        int mark1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the mark 2:");
        int mark2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the mark 3:");
        int mark3=int.Parse(Console.ReadLine());
        Percentage(mark1,mark2,mark3);



        void Percentage(int mark1,int mark2,int mark3)
        {
            System.Console.WriteLine($"mark1:{mark1} \n mark2:{mark2} \n mark3:{mark3}");
            double percent=(mark1+mark2+mark3)/300*100;
            System.Console.WriteLine("Percentage: "+percent);
        }
    }
}
