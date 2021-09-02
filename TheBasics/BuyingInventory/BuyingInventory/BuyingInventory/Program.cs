using System;

namespace BuyingInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int choice;
            string response;
            Console.WriteLine("The following items are available:\n" +
                "1 - Rope\n2 - Torches\n3 - Climbing Equipment\n" +
                "4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\n");
            Console.Write("What Number do u want to see the price of? ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your name ");
            name = Console.ReadLine();
            if (name == "juan")
            {
                response = choice switch
                {
                    1 => "Rope cost 5 gold",
                    2 => "Torches cost 7.5 gold",
                    3 => "Climbing Equiment cost 12.5 gold",
                    4 => "Clean Water cost 0.5 gold",
                    5 => "Machete cost 10 gold",
                    6 => "Canoe cost 100 gold",
                    7 => "Food suplies cost 0.5 gold",
                    _ => "Apologies. I dont have that one"
                };
            }
            else
            {
                response = choice switch
                {
                    1 => "Rope cost 10 gold",
                    2 => "Torches cost 15 gold",
                    3 => "Climbing Equiment cost 25 gold",
                    4 => "Clean Water cost 1 gold",
                    5 => "Machete cost 20 gold",
                    6 => "Canoe cost 200 gold",
                    7 => "Food suplies cost 1 gold",
                    _ => "Apologies. I dont have that one"
                };
            }
            Console.WriteLine(response);
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
