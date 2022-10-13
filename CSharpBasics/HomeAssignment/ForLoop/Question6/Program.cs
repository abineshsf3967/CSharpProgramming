using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of row: ");
        int row = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=row;i++)
        {
            for(int j=0;j<i;j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}