using System;
namespace Qusetion8;
class Program
{
    public static void Main(string[] args)
    {
         System.Console.WriteLine("Enter the row: ");
        int row=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter the column: ");
        int column=int.Parse(Console.ReadLine());
        int[,] matrix1=new int [row,column];
        for(int index=0;index<row;index++)
        {
            for(int index1=0;index1<column;index1++)
            {
                System.Console.WriteLine($"enter the value of {index} {index1}");
                matrix1[index,index1]=int.Parse(Console.ReadLine());
            }
        }
        int[,] matrix2=new int [row,column];
        for(int index=0;index<row;index++)
        {
            for(int index1=0;index1<column;index1++)
            {
                System.Console.WriteLine($"enter the value of {index} {index1}");
                matrix2[index,index1]=int.Parse(Console.ReadLine());
            }
        }

        int[,] matrix3=new int[row,column];
         for(int index=0;index<row;index++)
        {
            for(int index1=0;index1<column;index1++)
            {
               matrix3[index,index1]=matrix1[index,index1]+matrix2[index,index1];
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("The Matrix is :");
        for(int index=0;index<row;index++)
        {
            for(int index1=0;index1<column;index1++)
            {
                System.Console.Write($"{matrix3[index,index1]} ");
            }
            System.Console.WriteLine();
        }

    }
}