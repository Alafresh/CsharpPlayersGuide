using System;

namespace CountDown
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown(10);
            void CountDown(int number)
            {
                Console.WriteLine(number);
                if (number > 0)
                    CountDown(number - 1);
                    
            }
        }
    }
}
