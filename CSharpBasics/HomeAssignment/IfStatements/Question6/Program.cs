using System;
namespace Temperature;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the temperature: ");
        int temperature = Convert.ToInt32(Console.ReadLine());
        if(temperature<0)
        {
            System.Console.WriteLine("Freezing weather");
        }
        else if((temperature>=0) && (temperature<10))
        {
            System.Console.WriteLine("Very cold weather");
        }
        else if((temperature>=10) && (temperature<20))
        {
            System.Console.WriteLine("Cold weather");
        }
        else if((temperature>=20) && (temperature<30))
        {
            System.Console.WriteLine("Normal in Temp");
        }
        else if((temperature>=30) && (temperature<40))
        {
            System.Console.WriteLine("Its Hot");
        }
        else if(temperature>=40)
        {
            System.Console.WriteLine("Its very Hot");
        }
    }
}