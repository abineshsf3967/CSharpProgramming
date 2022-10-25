using System;
namespace CalculatorApp;
class Program
{
    public static void Main(string[] args)
    {
        CircleArea area1=new CircleArea();
        area1.CalculateCircleArea();
        System.Console.WriteLine();
        CylinderVolume volume1=new CylinderVolume();
        volume1.CalculateVolume();
    }
}
