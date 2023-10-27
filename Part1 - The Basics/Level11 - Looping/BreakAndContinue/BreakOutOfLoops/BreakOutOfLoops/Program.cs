using System;

namespace BreakOutOfLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Think of a number and type it here: ");
                string input = Console.ReadLine();

                if (input == "quit" || input == "exit")
                    break;

                int number = Convert.ToInt32(input);

                if (number == 12)
                {
                    Console.WriteLine("I dont like that number. Pick another one");
                    continue;
                }
                Console.WriteLine($"I like {number}. Its the one before {number + 1}");
            }
            int totalRows = 5;
            int totalColumns = 10;

            for (int currentRow = 1; currentRow <= totalRows; currentRow++)
            {
                for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
