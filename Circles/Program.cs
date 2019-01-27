using System;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            //console - ask for the circle's radius
            Console.Write("Enter a circles radius: ");
            string enteredRadius = Console.ReadLine();

            var circle1 = new Circle(int.Parse(enteredRadius);

            Console.WriteLine("We now have a circle with a radius of" + circle1.Radius);

            var radius = circle1.CalculatedRadius();
           
            
            //read it from the console
            //create a new circle object (constructor) with the raduis entered (convert from string to int)
            //call the Circle class's CalcualteCircumference method (store it in a variable)
            //write out the circumference to the conole.
            //call the Circle class's CalculateArea method (store it in a variable)
            //write out the area to the console
            //console read so it doesn't close


            Console.ReadLine();
        }
    }
}
