using System;

namespace MathsFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountDone = 20;
            int amountToDo = 100;
            double fractionDone = amountDone / amountToDo;
            double fractionCast = (double)amountDone / amountToDo;
            Console.WriteLine("{0} {1}", fractionDone, fractionCast);

            // area of a circle
            double radius = 2.75;
            double area = Math.PI * radius * radius;

            // power and square roots c# doesnt have operatos for powers and square roots but provides methods
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(9));

            //absolute value positive version of the number
            int x = Math.Abs(-3); // will be 3.

            // trigonometric functions seno, conseno, tangente in radians is necessary convert to degrees
            double y1 = 60;
            Console.WriteLine("seno: {0} coseno: {1}", Math.Sin(y1), Math.Cos(y1));
            double degreesY1 = (y1 * (Math.PI)) / 180;
            Console.WriteLine("seno: {0} coseno: {1}", Math.Sin(degreesY1), Math.Cos(degreesY1));

            // Math clamp if the value is within the range, value is returned
            // if that value is lower than the range, it produces the low
            //if that value is higher than the range, it produces the high
            Console.WriteLine("en rango: {0} fuera de rango: {1} fuera de rango {2}",
                Math.Clamp(10, 0, 100), Math.Clamp(-1, 0, 100), Math.Clamp(101, 0, 100));
        }
    }
}
