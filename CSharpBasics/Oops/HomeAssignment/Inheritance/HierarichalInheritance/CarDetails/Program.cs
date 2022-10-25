using System;
namespace CarDetails;
class Program
{
    public static void Main(string[] args)
    {
        Tata car1=new Tata(1234,345,7890,30,4,300,new DateTime(2022,10,22),"TataNexa");
        car1.CalculateMilageTata();
        car1.TataDetails();
        System.Console.WriteLine();
        Suzuki car2=new Suzuki(1234,345,7890,30,4,300,new DateTime(2022,10,22),"Swift");
        car2.CalculateMilageSuzuki();
        car2.SuzukiDetails();
    }
}