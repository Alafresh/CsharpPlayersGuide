using System;

namespace AreaOfATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello write the base of ur triangle");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hello write the height of ur triangle");
            float h = Convert.ToSingle(Console.ReadLine());
            float area = (b * h) / 2;
            Console.WriteLine("The area of ur triangle is {0}", area);
            float i = 5;
            float l = 2;
            Console.WriteLine(i / l);
        }
    }
}
