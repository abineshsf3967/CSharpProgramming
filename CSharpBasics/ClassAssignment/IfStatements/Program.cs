﻿using System;
namespace IfStatements;
class Program
{
    public static void Main()
    {
        System.Console.Write("Input: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        if(mark>80 && mark<=100)
        {
            System.Console.WriteLine("Grade A");
        }
        else if(mark>60 && mark<=80)
        {
            System.Console.WriteLine("Grade B");
        }
        else if(mark>35 && mark<=60)
        {
            System.Console.WriteLine("Grade C");
        }
        else if(mark<=35 && mark>=0)
        {
            System.Console.WriteLine("Grade D");
        }
        else
        {
            System.Console.WriteLine("Invalid input");
        }
    }
}