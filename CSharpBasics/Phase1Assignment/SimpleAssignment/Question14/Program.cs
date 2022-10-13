using System;
namespace Question14;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of rows: ");
        int rows=int.Parse(Console.ReadLine());
        System.Console.WriteLine();
        int k=1;
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<=i;j++)
            {
                System.Console.Write(k);
            }
            System.Console.WriteLine();
            k++;
        }
    }
}