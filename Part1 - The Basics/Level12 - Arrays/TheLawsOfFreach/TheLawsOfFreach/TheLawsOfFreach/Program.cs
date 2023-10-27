using System;

namespace TheLawsOfFreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = int.MaxValue;

            foreach(int item in array)
            {
                if (item < currentMinimum)
                    currentMinimum = item;
            }
            Console.WriteLine(currentMinimum);
            int total = 0;
            foreach(int item in array)
            {
                total += item;
            }
            float average = (float)total / array.Length;
            Console.WriteLine(average);

            int[,] matrix = new int[4, 4];

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
