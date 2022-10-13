using System;
namespace DistanceTravelled;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speed in km/hr : ");
        int speed = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the time travelled in sec: ");
        int time = Convert.ToInt32(Console.ReadLine());
        int distanceTravelled = speed*time*5/18;
        System.Console.WriteLine("Distance Travelled: "+distanceTravelled);
    }
}