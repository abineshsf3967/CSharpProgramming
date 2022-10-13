using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of rows: ");
        int row=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of column: ");
        int column=int.Parse(Console.ReadLine());
        int[,] matrix1=new int[row,column];
        int[,] matrix2=new int[row,column];
        int[,] sum=new int[row,column];
        System.Console.WriteLine("Enter first matrix: ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                System.Console.WriteLine($"enter the value {i} {j}: ");
                matrix1[i,j]=int.Parse(Console.ReadLine());

            }
        }
        System.Console.WriteLine("Enter second matrix: ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                System.Console.WriteLine($"enter the value {i} {j}: ");
                matrix2[i,j]=int.Parse(Console.ReadLine());

            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
               
                sum[i,j]=matrix1[i,j]+matrix2[i,j];
            }
        }
        System.Console.WriteLine("sum of matrix: ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
               
               System.Console.Write($"{sum[i,j]} ");
            }
            System.Console.WriteLine();
        }
        
    }
}
