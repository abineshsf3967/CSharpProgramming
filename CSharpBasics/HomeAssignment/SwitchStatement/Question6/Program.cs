using System;
namespace Circle;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius of circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Choose the required option: \n1.Area \n2.Perimeter \n3.Diameter");
        System.Console.WriteLine("your option: ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
                   {
                    System.Console.WriteLine("Area of circle: "+Math.Round((double)(3.14*radius*radius),2));
                   }
                   break;
             case 2:
                   {
                    System.Console.WriteLine("Perimeter of circle: "+Math.Round((double)(2*3.14*radius),2));
                   }
                   break; 
             case 3:
                   {
                    System.Console.WriteLine("diameter of circle: "+Math.Round((double)(radius*2),2));
                   }
                   break;         
            default :
                    {
                        System.Console.WriteLine("Invalid Option");
                    }  
                    break;     
        }
    }
}