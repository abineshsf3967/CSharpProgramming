using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the breath: ");
        int breath=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the lenght: ");
        int length=int.Parse(Console.ReadLine());
        for(int i=1;i<=breath;i++)
        {
            for(int j=1;j<=length;j++)
            {
                if(i==1)
                {
                    System.Console.Write("*");
                }
                else if(i==breath)
                {
                    System.Console.Write("*");
                }
                else if(j==1)
                {
                    System.Console.Write("*");
                }
                else if(j==length)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}
