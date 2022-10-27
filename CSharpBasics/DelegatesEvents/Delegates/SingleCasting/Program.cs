using System;
namespace SingleCasting;
public delegate int Calculator(int value);
class Program
{
    static int value=10;
    public static int Add(int number)
    {
        value+=number;
        return value;
    }
    public static int Multiply(int number)
    {
        value*=number;
        return value;
    }
    public static int GetNum()
    {
        return value;
    }
    public static void Main(string[] args)
    {
        Calculator element1=new Calculator(Add);
        Calculator element2=new Calculator(Multiply);
        element1(5);
        System.Console.WriteLine(GetNum());
        element2(2);
        System.Console.WriteLine(GetNum());
    }
}