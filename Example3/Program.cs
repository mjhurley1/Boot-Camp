using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sampleBoolean = true; //boolean is true or false only
            Console.WriteLine("sampleBoolean is equal to " + sampleBoolean);

            sampleBoolean = false;
            Console.WriteLine("we changed sampleBoolean's value to " + sampleBoolean);

            string sampleString = "This is a string variable"; //string contains alphanumeric chatacters (text)
            Console.WriteLine("sampleString is equal to " + sampleString);

            sampleString = "I have updated this variable!";
            Console.WriteLine("we changed sampleString's value to " + sampleString);

            int sampleInteger = 0; //int contains whole numbers only
            Console.WriteLine("sampleInteger is equal to " + sampleInteger);

            sampleInteger = -4000;
            Console.WriteLine("we changed sampleInteger's value to " + sampleInteger);

            double sampleDecimal = 33.3334; //double conatins a decimal number - decimal and float are similar types
            Console.WriteLine("sampleDecimal is equal to " + sampleDecimal);

            object a = 1;  // object can contain anything

            var b = 33.33;  //var is shortcut for creating variables.  it's type is determined by assignment (value)

            int someNumber;
            someNumber = sampleInteger;

            Console.ReadLine();

        }
    }
}
