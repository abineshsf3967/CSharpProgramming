using System;
namespace ElectricityBill;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Customer Id: ");
        int customerId = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the customer name: ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter the unit consumed: ");
        int unit = Convert.ToInt32(Console.ReadLine());
        if(unit<=199)
        {
            double charge = unit*1.20;
            if(charge<100)
            {
                System.Console.WriteLine("The minimum bill should be of RS.100/-");
            }
            else if(charge>400)
            {
            System.Console.WriteLine("Amount charges @Rs.1.20 per unit: "+charge);
            double surcharge = 0.15*charge;
            System.Console.WriteLine("Surcharge amount: "+surcharge);
            System.Console.WriteLine("Net Amount paid by the Customer: "+(charge+surcharge));
            }
        }
        else if((unit>=200) && (unit<400))
        {
            double charge = unit*1.50;
            if(charge<100)
            {
                System.Console.WriteLine("The minimum bill should be of RS.100/-");
            }
            else if(charge>400)
            {
            System.Console.WriteLine("Amount charges @Rs.1.50 per unit: "+charge);
            double surcharge = 0.15*charge;
            System.Console.WriteLine("Surcharge amount: "+surcharge);
            System.Console.WriteLine("Net Amount paid by the Customer: "+(charge+surcharge));
            }
        }
        else if((unit>=400) && (unit<600))
        {
            double charge = unit*1.80;
            if(charge<100)
            {
                System.Console.WriteLine("The minimum bill should be of RS.100/-");
            }
            else if(charge>400)
            {
            System.Console.WriteLine("Amount charges @Rs.1.80 per unit: "+charge);
            double surcharge = 0.15*charge;
            System.Console.WriteLine("Surcharge amount: "+surcharge);
            System.Console.WriteLine("Net Amount paid by the Customer: "+(charge+surcharge));
            }
        }
        else if(unit>=600)
        {
            double charge = unit*2;
            if(charge<100)
            {
                System.Console.WriteLine("The minimum bill should be of RS.100/-");
            }
            else if(charge>400)
            {
            System.Console.WriteLine("Amount charges @Rs.2.00 per unit: "+charge);
            double surcharge = 0.15*charge;
            System.Console.WriteLine("Surcharge amount: "+surcharge);
            System.Console.WriteLine("Net Amount paid by the Customer: "+(charge+surcharge));
            }
        }

    }
}
