using System;
namespace CarDetails
{
    public class Tata:CarInfo
    {
        private static int s_carModelNumber=100;
        public string CarModelNumber { get; set; }
        public string CarModelName { get; set; }


        public Tata(int rcBookNumber,int engineeNumber,int chasisNumber,double tankCapacity,int numberOfSeats,double numberOfKMDriven,DateTime dateOfPurchase,string modelName):base(rcBookNumber,engineeNumber,chasisNumber,tankCapacity,numberOfSeats,numberOfKMDriven,dateOfPurchase)
        {
            s_carModelNumber++;
            CarModelNumber="CID"+s_carModelNumber;
            CarModelName=modelName;
        }
         public void CalculateMilageTata()
        {
            System.Console.WriteLine("Enter the tank quantity of petrol filled: ");
            double tankFilled=double.Parse(Console.ReadLine());
            Milage=NumberOfKMDriven/tankFilled;
        }

        public void TataDetails()
        {
            System.Console.WriteLine("Car model number: "+CarModelNumber);
            System.Console.WriteLine("Car model Name: "+CarModelName);
            ShowCarinfo();
        }
    }
}