using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the start year: ");
        int year1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("enter the end year: ");
        int year2=int.Parse(Console.ReadLine());
        System.Console.WriteLine();
        for(int check=year1;check<=year2;check++)
        {
            if(check%400==0)
            {
                System.Console.WriteLine(" "+check);
            }
            else if(check%4==0 && check%100!=0)
            {
                System.Console.WriteLine(" "+check);
            }
        }
    }
}
