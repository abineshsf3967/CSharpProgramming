using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the base value: ");
        int baseValue=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the power value: ");
        int power=int.Parse(Console.ReadLine());
        int power1=power;
        int result=0;
        while(power>0)
        {
            result+=baseValue;
            power--;
        }
        System.Console.WriteLine($"{baseValue} power {power1} is: "+result);
    }
}