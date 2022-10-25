using System;
namespace CarDetails
{
    public class CarInfo
    {
        public int RCBBookNumber { get; set; }
        public int EngineNumber { get; set; }
        public int ChasisNumber { get; set; }
        public double Milage { get; set; }
        public double TankCapacity { get; set; }
        public int NumberSeats { get; set; }
        public double NumberOfKMDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public CarInfo(int rcBookNumber,int engineeNumber,int chasisNumber,double tankCapacity,int numberOfSeats,double numberOfKMDriven,DateTime dateOfPurchase)
        {
            RCBBookNumber=rcBookNumber;
            EngineNumber=engineeNumber;
            ChasisNumber=chasisNumber;
            TankCapacity=tankCapacity;
            NumberSeats=numberOfSeats;
            NumberOfKMDriven=numberOfKMDriven;
            DateOfPurchase=dateOfPurchase;
        }


        public void CalculateMilage()
        {
            System.Console.WriteLine("Enter the tank quantity of petrol filled: ");
            double tankFilled=double.Parse(Console.ReadLine());
            Milage=NumberOfKMDriven/tankFilled;
        }

        public void ShowCarinfo()
        {
            System.Console.WriteLine("RCBookNumber: "+RCBBookNumber);
            System.Console.WriteLine("EngineeNumber: "+EngineNumber);
            System.Console.WriteLine("ChasisNumber: "+ChasisNumber);
            System.Console.WriteLine("Milage: "+Milage);
            System.Console.WriteLine("Tank Capacity: "+TankCapacity);
            System.Console.WriteLine("Number of Seats: "+NumberSeats);
            System.Console.WriteLine("Number of Km Driven: "+NumberOfKMDriven);
            System.Console.WriteLine("Date of Purchase: "+DateOfPurchase);
        }
    }
}