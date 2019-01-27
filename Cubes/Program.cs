
using System;

namespace Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a height: ");
            string enteredHeight = Console.ReadLine();

            Console.Write("Enter a width: ");
            string enteredWidth = Console.ReadLine();

            Console.Write("Enter a length: ");
            string enteredLength = Console.ReadLine();

            var cube1 = new Cube(int.Parse(enteredLength), int.Parse(enteredHeight), int.Parse(enteredWidth));
            //cube1.Height = 3;
            //cube1.Width = 5;
            //cube1.Length = 10;

            Console.WriteLine("we now have a cube with the length of " + cube1.Length + " and a width of " + cube1.Width + " and a height of " + cube1.Height);

            var area = cube1.CalcualteArea();

            Console.WriteLine("The area of my cube is " + area);

            var surfaceArea = cube1.CalculateSurfaceArea();
            Console.WriteLine("The surface area of my cube is " + surfaceArea);

            Console.ReadLine();
        }
    }
}
