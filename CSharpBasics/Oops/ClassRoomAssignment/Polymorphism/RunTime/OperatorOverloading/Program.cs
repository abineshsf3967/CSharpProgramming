using System;
namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(10.5,15,20);
        System.Console.WriteLine("volume 1: "+box1.CalculateVolume());
        Box box2=new Box(11.5,10,15);
        System.Console.WriteLine("volume 2: "+box2.CalculateVolume()); 
        Box box3;
        Box box4=new Box();
        box3=box1+box2;
        box4=box4.Add(box1,box2);
        System.Console.WriteLine("volume 3: "+box3.CalculateVolume());
        System.Console.WriteLine("volume 3: "+box4.CalculateVolume());
        

    }
}