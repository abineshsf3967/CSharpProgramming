using System;
namespace Linear;
 class Prgram
 {
    public static void Main(string[] args)
    {
        int[] numbers={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        System.Console.WriteLine("Enter the  number do you want to find: ");
        int findNumber=int.Parse(Console.ReadLine());
        int temp=0;
        for(int value=1;value<20;value++)
        {
            if(numbers[value]==findNumber)
            {
                System.Console.WriteLine($"The number {findNumber} in index {value}");
                temp=0;
                break;
            }
            else
            {
                temp=1;
            }
        }
        if(temp==1)
        {
            System.Console.WriteLine("Number not in array");
        }

    }
 }
