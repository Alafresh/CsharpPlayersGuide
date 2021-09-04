using System;

namespace ThePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("User 1, enter a number between 0 and 100: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 100)
                    continue;
                else
                {
                    Console.Clear();
                    Console.WriteLine("User 2, guess the number.");
                    while (true)
                    {
                        Console.Write("What is your next guess? ");
                        int guess = Convert.ToInt32(Console.ReadLine());
                        if (num == guess)
                        {
                            Console.WriteLine("You guessed the number!");
                            break;
                        }
                        else if (guess < num)
                            Console.WriteLine($"{guess} is too low.");
                        else
                            Console.WriteLine($"{guess} is too high");
                    }
                    break;
                }
            }
        }
    }
}
