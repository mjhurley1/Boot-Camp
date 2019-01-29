using System;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            //console - ask for the circle's radius
            Console.Write("Enter a circles radius: ");

            //read it from the console
            string enteredRadius = Console.ReadLine();

            //create a new circle object (constructor) with the raduis entered (convert from string to int)
            var radius = int.Parse(enteredRadius);
            var circle1 = new Circle(radius);
            Console.WriteLine("We now have a circle with a radius of " + circle1.Radius);

            //call the Circle class's CalcualteCircumference method (store it in a variable)
            double circumference = circle1.CalculatedCircumference();

            //write out the circumference to the conole.
            Console.WriteLine("The circumference of my circle is " + circumference);

            //call the Circle class's CalculateArea method (store it in a variable)
            double area = circle1.CalculateArea();

            //write out the area to the console
            Console.WriteLine("The area of my circle is " + area);

            //console read so it doesn't close
            Console.ReadLine();
        }
    }
}
