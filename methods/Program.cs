using System;

namespace methods
{
    class Program
    {
        const double pi = 3.14;
        const int dozen = 12;

        static void Main(string[] args)
        {
            Console.Write("Enter a diameter: ");
            string enteredValue = Console.ReadLine();

            int diameter = int.Parse(enteredValue);

            double circumference = CalculateCircumference(diameter);
            double area = CalculateArea(diameter);

            Console.WriteLine("A circle with a diameter of " + diameter + " has a circumference of " + circumference);
            Console.WriteLine("A circle with a diameter of " + diameter + " has an area of " + area);
            Console.ReadLine();
        }

        public static double CalculateCircumference(int diameter)
        {
            return diameter * pi;
        }

        public static double CalculateArea(int diameter)
        {
            double radius = (double)diameter / 2;
            return pi * radius * radius;
        }
    }
}
