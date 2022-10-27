﻿using System;
namespace ActionDelegate;
class Program
{
     static void Sum(int number1,int number2)
    {
        System.Console.WriteLine("Output: "+(number1+number2));
    }
    static void Multiply(int number1,int number2)
    {
        System.Console.WriteLine("Output: "+number1*number2); 
    }
    static  void Calculator(Action<int,int> action,int x,int y)
    {
         action(x,y);
    }
    public static void Main(string[] args)
    {
         Action<int,int> action =Sum;
         action+=Multiply;
         action(10,20);
         Calculator(Sum,10,20);
    }
}