using System;

namespace DefenseOfConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";
            int row;
            int column;
            Console.Write("Target Row ? ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column ? ");
            column = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Deploy to:\n" +
                $"({row}, {column - 1})\n" +
                $"({row - 1}, {column})\n" +
                $"({row}, {column + 1})\n" +
                $"({row + 1}, {column})\n");
            Console.Beep(200, 2000);
        }
    }
}
