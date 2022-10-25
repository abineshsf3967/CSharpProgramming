namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
    {
        private static double s_height=10;
        public double Height { get; set; }
        internal double Volume { get; set; }

        public CylinderVolume()
        {
            s_height++;
            Height=s_height;
        }
        public void CalculateVolume()
        {
            Volume=Area*Height;
            System.Console.WriteLine("Cylinder Volume: "+Volume);
        }
        
    }
}