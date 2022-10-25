using System;
namespace MathsLib
{
    public class Maths
    {
        protected internal double  PI=3.14;
        internal double g=9.8;
        public void CalculateWeight()
        {
            System.Console.WriteLine("Enter the Mass: ");
            double mass=double.Parse(Console.ReadLine());
            double weight=mass*g;
        }
    }
}