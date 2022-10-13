using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the row: ");
        int row = Convert.ToInt32(Console.ReadLine());
        int k=1;
        for(int i=1;i<=row;i++)
        {
            for(int space=row-1;space-i>=0;space--)
            {
                System.Console.Write(" ");
            }
            for(int j=1;j<=i;j++)
            {
                System.Console.Write(k+" ");
                k++;
            }
            System.Console.WriteLine();
        }
    }
}
