﻿using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number= Convert.ToInt32(Console.ReadLine());
        int temp=number;
        int i;
        for( i=2;i<=number;i++)
        {
            if(number%i==0)
            break;
        }
        if(number==i)
        {
            System.Console.WriteLine($"{number} is prime number");
        }
        else
        {
            System.Console.WriteLine($"{number} is not prime number");
        }
    }
}
