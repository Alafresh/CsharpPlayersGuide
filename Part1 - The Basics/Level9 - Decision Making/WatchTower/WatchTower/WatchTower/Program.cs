using System;

namespace WatchTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter x value ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("The enemy is to the Northeast!");
            else if (x > 0 && y == 0)
                Console.WriteLine("The enemy is to the East!");
            else if (x > 0 && y < 0)
                Console.WriteLine("The enemy is to the Southeast!");
            else if (x == 0 && y > 0)
                Console.WriteLine("The enemy is to the North");
            else if (x < 0 && y > 0)
                Console.WriteLine("The enemy is to the Northwest!");
            else if (x < 0 && y < 0)
                Console.WriteLine("The enemy is to the Southwest!");
            else if (x == 0 && y < 0)
                Console.WriteLine("The enemy is to the South!");
            else if (x < 0 && y == 0)
                Console.WriteLine("The enemy is to the West!");
            else
                Console.WriteLine("The enemy is here!");
        }
    }
}
