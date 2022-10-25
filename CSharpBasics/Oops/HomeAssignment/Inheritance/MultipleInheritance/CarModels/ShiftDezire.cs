namespace CarModels
{
    public class ShiftDezire:Car,Brand
    {
        private static int s_makingID=100;
        public string MakingID { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int EngineeNumber { get; set; }
        public int ChasisNumber { get; set; }

        public ShiftDezire(string fuelType,int numberOfSeats,string color,int tankCapacity,double numberOfKMDriven,string brandName,string modelName,int engineeNumber,int chasisNumber):base(fuelType,numberOfSeats,color,tankCapacity,numberOfKMDriven)
        {
            s_makingID++;
            MakingID="SF"+s_makingID;
            BrandName=brandName;
            ModelName=modelName;
            EngineeNumber=engineeNumber;
            ChasisNumber=chasisNumber;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("MakingID: "+MakingID);
            System.Console.WriteLine("Brand Name: "+BrandName);
            System.Console.WriteLine("Model Name: "+ModelName);
            System.Console.WriteLine("Enginee Number: "+EngineeNumber);
            System.Console.WriteLine("Chasis Number: "+ChasisNumber);
            CarInfo();
        }
    }
}