using System;

namespace TheReplicatorOfDto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 5; j++)
                arr2[j] = arr1[j];
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"original: {arr1[i]} and copy: {arr2[i]}");

            //int[] theMiddle = arr2[1..^1]; except fist and last item
            //int[] theMiddle = arr2[..]; copy all the array
            int[] theMiddle = arr2[0..3]; // first three number 0 1 2
            for (int i = 0; i < theMiddle.Length; i++)
            {
                Console.WriteLine(theMiddle[i]);
            }
            
        }
    }
}
