﻿namespace Circles
{
    public class Circle
    {
        const double Pi = 3.14;

        //properties
        public int Radius { get; set; }

        //constructor
        public Circle(int radius)
        {
            Radius = radius;
        }

        //methods
        public double CalculatedCircumference()
        {
            return Radius * Pi;
        }

        public double CalculateArea()
        {
            return Radius * Radius * Pi;
        }
    }
}
        

 
