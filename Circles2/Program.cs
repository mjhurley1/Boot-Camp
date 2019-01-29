using System;
using System.Collections.Generic;

namespace Circles2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();

            var enteredRadius = "";

            //continuosly ask user for a radius of a circle
            while (enteredRadius != "done")
            {
                enteredRadius = AskUserForaRadius();
                if (enteredRadius != "done")
                {
                    var radius = int.Parse(enteredRadius);
                    var circle = new Circle(radius);
                    circles.Add(circle);
                }
            }
            
            foreach(var c in circles)
            {
                WriteCircumferenceToConsole(c);
                WriteAreaToConsole(c);
            }

            //console readline so it doesn't close
            Console.ReadLine();
        }

        static string AskUserForaRadius()
        {
            Console.Write("Enter a radius (or done): ");
            return Console.ReadLine();
        }

        static void WriteCircumferenceToConsole(Circle c)
        {
            var circumference = c.CalculateCircumference();
            Console.WriteLine("A circle with a radius of " + c.Radius + " has a circumference of " + circumference);
        }

        static void WriteAreaToConsole(Circle c)
        {
            var area = c.Calculatearea();
            Console.WriteLine("A circle with a radius of " + c.Radius + " has an area of " + area);
        }
    }
}
