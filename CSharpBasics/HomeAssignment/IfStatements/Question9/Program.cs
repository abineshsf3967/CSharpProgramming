using System;
namespace Season;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the season: ");
        string season = Console.ReadLine().ToLower();
        if((season=="december" || season=="january" || season=="februry"))
        {
            System.Console.WriteLine("winter");
        }
        else if((season=="march") || (season=="april") || (season=="may"))
        {
            System.Console.WriteLine("spring");
        }
        else if((season=="june") || (season=="july") || (season=="august"))
        {
            System.Console.WriteLine("summer");
        }
        else if((season=="september") || (season=="october") || (season=="november"))
        {
            System.Console.WriteLine("rainfall");
        }
    }
}