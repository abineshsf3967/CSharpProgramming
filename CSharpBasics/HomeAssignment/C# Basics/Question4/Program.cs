using System;
namespace VolumeOfCylinder;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        double volumeOfCylinder = 3.14*(radius*radius)*height;
        System.Console.WriteLine("Volume: "+volumeOfCylinder);
    }
}
