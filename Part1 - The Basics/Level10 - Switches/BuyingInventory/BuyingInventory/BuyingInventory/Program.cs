using System;

namespace BuyingInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            float price;
            string name;
            int choice;
            string response;
            Console.WriteLine("The following items are available:\n" +
                "1 - Rope\n2 - Torches\n3 - Climbing Equipment\n" +
                "4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n");
            Console.Write("What Number do u want to see the price of? ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 7)
            {
                Console.WriteLine("That option it no available");
                Environment.Exit(0);
            }
            response = choice switch
            {
                1 => "Rope",
                2 => "Torches",
                3 => "Climbing Equipment",
                4 => "Clean Water",
                5 => "Machete",
                6 => "Canoe",
                7 => "Food Supplies",
            };
            price = response switch
            {
                "Rope" => 10,
                "Torches" => 15,
                "Climbing Equipment" => 25,
                "Clean Water" => 1,
                "Machete" => 20,
                "Canoe" => 200,
                "Food Supplies" => 1,
            };
            Console.Write("What is your name ");
            name = Console.ReadLine();
            if (name == "juan")
                price /= 2;
            Console.WriteLine($"{response} cost {price} gold.");
            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Rope cost 10 gold");
            //        break;
            //    case 2:
            //        Console.WriteLine("Torches cost 15 gold");
            //        break;
            //    case 3:
            //        Console.WriteLine("Climbing Equiment cost 25 gold");
            //        break;
            //    case 4:
            //        Console.WriteLine("Clean Water cost 1 gold");
            //        break;
            //    case 5:
            //        Console.WriteLine("Machete cost 20 gold");
            //        break;
            //    case 6:
            //        Console.WriteLine("Canoe cost 200 gold");
            //        break;
            //    case 7:
            //        Console.WriteLine("Food suplies cost 1 gold");
            //        break;
            //    default:
            //        Console.WriteLine("Apologies. I dont have that one");
            //        break;
            //}
        }
    }
}
