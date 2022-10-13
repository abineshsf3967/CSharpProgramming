using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int count=2;
        System.Console.WriteLine(" Enter the number of terms: ");
        int terms=int.Parse(Console.ReadLine());
        int input1=0,input2=1;
        System.Console.Write(input1+" "+input2);
        do
        {
            int input3=input1+input2;
            System.Console.Write(" "+input3);
            input1=input2;
            input2=input3;
            count++;
        }while(count<terms);
        
    }
}