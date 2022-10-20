using System;
namespace ValueReferenceType;
class Program
{
    public static void Main(string[] args)
    {
        int number1=10;
        int number2=number1;
        System.Console.WriteLine($"number1: {number1}   number2: {number2}");

        //value type
        number2=40;
        System.Console.WriteLine($"number1: {number1}   number2: {number2}");

        //reference type
        ReferenceType object1;
        object1=new ReferenceType();

        object1.Number=10;
        ReferenceType object2=object1;

        System.Console.WriteLine($"Number of object1: {object1.Number}   Number of object2: {object2.Number}");

        object2.Number=40;

        System.Console.WriteLine($"Number of object1: {object1.Number}   Number of object2: {object2.Number}");
    }
}