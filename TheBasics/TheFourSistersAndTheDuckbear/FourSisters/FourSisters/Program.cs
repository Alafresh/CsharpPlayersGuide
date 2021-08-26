using System;

namespace FourSisters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of chocolate eggs gathered today");
            int eggs = Convert.ToInt32(Console.ReadLine());
            int forDuckbear = eggs % 4;
            int forSister = eggs / 4;
            Console.WriteLine("For each sister is {0} and for the duckbear is {1}", forSister, forDuckbear);
        }
    }
}
