using System;

namespace ConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello world!";
            Console.Beep(440, 1000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key when you're ready to begin. ");
            Console.ReadKey(true);
            Console.WriteLine("Hola\nMundo");
            Console.WriteLine("C:\\Users\\RB\\Desktop\\MyFile.txt");
            Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt");
            int favoriteNumber = 4;
            Console.WriteLine($"My favorite number is {favoriteNumber}.");
            Console.WriteLine($"{Math.PI:0.000}");
        }
    }
}
