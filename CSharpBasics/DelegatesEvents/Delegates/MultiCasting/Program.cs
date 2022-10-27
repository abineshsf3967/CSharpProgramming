using System;
namespace MultiCasting;
public delegate int Calculator(int value);
class Program
{
     static int value=10;
    public static int Add(int p)
    {
        value+=p;
         System.Console.WriteLine(value);
        return value;
    }
    public static int Multiply(int q)
    {
        value*=q;
        return value;
    }
    public static int GetNum()
    {
        return value;
    }
    public static void Main(string[] args)
    {
        
        Calculator element1;
        element1=new Calculator(Add);
        element1+=new Calculator(Multiply);
        element1(5);
        System.Console.WriteLine(GetNum());
    }
}