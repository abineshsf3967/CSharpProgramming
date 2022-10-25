using MathsLib;
using System;
namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        protected double s_radius=5;
        public double Radius { get; set; }
        internal double Area { get; set; }
         
         public CircleArea()
         {
            s_radius++;
            Radius=s_radius;
         }
        public void CalculateCircleArea()
        {
            Area=PI*Radius*Radius;
            System.Console.WriteLine("Circle Area: "+Math.Round(Area,2));
        }
    }
}