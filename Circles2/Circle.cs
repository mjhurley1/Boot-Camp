namespace Circles2
{
    public class Circle
    {
        const double Pi = 3.14;

        //properties
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        //methods
        public double CalculateCircumference()
        {
            return Radius * Pi;
        }

        public double Calculatearea()
        {
            return Radius * Radius * Pi;
        }
    }
}
