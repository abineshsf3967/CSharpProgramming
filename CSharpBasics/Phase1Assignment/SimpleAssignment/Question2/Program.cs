using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius of circle: ");
        double radius=double.Parse(Console.ReadLine());
        double areaOfCircle=3.14*(radius*radius);
        double perimeterOfCircle=2*3.14*radius;
        System.Console.WriteLine("Area: "+areaOfCircle);
        System.Console.WriteLine("Perimeter: "+perimeterOfCircle);
    }
}
