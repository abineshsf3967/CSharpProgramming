using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the row: ");
        int row = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=row;i++)
        {
            for(int space=row-1;space-i>=0;space--)
            {
                System.Console.Write("  ");
            }
            for(int j=2;j<=i*2;j++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}
