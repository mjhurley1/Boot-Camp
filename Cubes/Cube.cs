namespace Cubes
{
    //this is a blue print of a Cube
    public class Cube
    {
        //properties
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //constructor
        public Cube(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        //methods
        public double CalcualteArea()
        {
            return (double)Height * Width * Length;
        }

        public int CalculateSurfaceArea()
        {
            var smallSideArea = Length * Width;
            var longSideArea = Length * Height;

            return smallSideArea * 2 + longSideArea * 4;
        }
    }
}
