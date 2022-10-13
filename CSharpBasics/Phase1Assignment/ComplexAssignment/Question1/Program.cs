using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of rows for matrix1: ");
        int row=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the column for matrix1: ");
        int column=int.Parse(Console.ReadLine());
        int[,] matrix1=new int[row,column];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                 System.Console.WriteLine($"Enter the matrix2 {i}{j}");
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }    
        System.Console.WriteLine("Enter the number of rows for matrix2: ");
        int row2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the column for matrix2: ");
        int column2=int.Parse(Console.ReadLine());
        int[,] matrix2=new int[row2,column2];
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<column2;j++)
            {
                System.Console.WriteLine($"Enter the matri2 {i}{j}");
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }    
        int[,] matrix3=new int[row,column2];
         for(int i=0;i<row;i++)
        {
            for(int j=0;j<column2;j++)
            {
                for(int k=0;k<column;k++)
                {
                    matrix3[i,j]=matrix3[i,j]+(matrix1[i,k]*matrix2[k,j]);
                }
            }
        }   
        System.Console.WriteLine(); 
        System.Console.WriteLine("Multipilication of matrix: ");
         for(int i=0;i<row;i++)
        {
            for(int j=0;j<column2;j++)
            {
                System.Console.Write($"{matrix3[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }      

}
