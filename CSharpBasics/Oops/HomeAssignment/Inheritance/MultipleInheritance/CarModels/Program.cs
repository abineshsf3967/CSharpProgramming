using System;
namespace CarModels;
class Program
{
    public static void Main(string[] args)
    {
        ShiftDezire car1=new ShiftDezire("Petrol",4,"Blue",25,300,"Shift","Dezire",1234,5678);
        car1.ShowDetails();
        System.Console.WriteLine();
        Eco car2=new Eco("Petrol",4,"Blue",25,300,"Tata","Nexa",1234,5678);
        car2.ShowDetails();
    }
}