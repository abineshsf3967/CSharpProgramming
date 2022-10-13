using System;
namespace CricketPlayer;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Choose the option given below: \n India \nPakistan \nBangladesh");
        System.Console.WriteLine("Enter your favourite: ");
        string country = Console.ReadLine().ToUpper();
        switch(country)
        {
            case "INDIA":
                        {
                            System.Console.WriteLine("\n1.Gambir \n2.Ashwin \n3.Dhoni \n4.Jadeja");
                        }
                        break;
            case "PAKISTAN":
                        {
                            System.Console.WriteLine("\n1.Babar Azam \n2.Rizwan \n3.Asan Ali \n4.Afridi");
                        }
                        break;       
            case "BANGLADESH":
                        {
                            System.Console.WriteLine("\n1.Shakib \n2.Rahman \n3.Mortaza \n4.Taskin");
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
