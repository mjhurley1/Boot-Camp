using System;

namespace Area_of_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height.");
            string enteredHeight = Console.ReadLine();

            Console.WriteLine("Enter width.");
            string enteredWidth = Console.ReadLine();

            int height = int.Parse(enteredHeight);
            int width = int.Parse(enteredWidth);

            double area = CalculateArea(height, width);

            Console.WriteLine("A rectangle with a height of " + height + " and width of " + width + " has an area of " + area);
            Console.ReadLine();
        }

        public static double CalculateArea(int height, int width)
        {
            return (double)height * width;
        }
    }
        
}
