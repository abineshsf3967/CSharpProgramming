namespace CarModels
{
    public class Car
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int TankCapacity { get; set; }
        public double NumberOfKMDriven { get; set; }


        public Car(string fuelType,int numberOfSeats,string color,int tankCapacity,double numberOfKMDriven)
        {
            FuelType=fuelType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKMDriven=numberOfKMDriven;
        }

        public void CarInfo()
        {
            System.Console.WriteLine("FuelType: "+FuelType);
            System.Console.WriteLine("Number of seats: "+NumberOfSeats);
            System.Console.WriteLine("Color: "+Color);
            System.Console.WriteLine("Tank Capacity: "+TankCapacity);
            System.Console.WriteLine("Number of KM Driven: "+NumberOfKMDriven);
        }
    }
}