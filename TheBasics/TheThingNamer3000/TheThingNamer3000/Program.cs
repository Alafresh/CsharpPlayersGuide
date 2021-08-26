using System;

namespace TheThingNamer3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about");
            // thing type
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? big? azure? tattered?");
            //thing description
            string b = Console.ReadLine();
            //remove double of
            string c = "of Doom";
            //number
            string d = "3000";
            Console.WriteLine("the {0} {1} {2} {3} !", b, a, c, d);

        }
    }
}
