using System;

namespace TheVariableShop
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aSingleByte = 0233;
            short aNumber = 10233;
            int number = 12032222;
            long bigNumber = 1203910239L;
            sbyte negativeOrPositiveByte = -12;
            ushort positiveShort = 9213;
            uint positiveNumber = 419943209U;
            ulong positiveBigNumber = 10000000000UL;

            char letra = 'a';
            string palabra = "fuck u";

            float realNumber = 1.23F;
            double dobleNumber = 1.342;
            decimal precisionNumber = 1.29398292893M;

            bool flag = true;

            Console.WriteLine(aSingleByte);
            Console.WriteLine(aNumber);
            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(negativeOrPositiveByte);
            Console.WriteLine(positiveShort);
            Console.WriteLine(positiveNumber);
            Console.WriteLine(positiveBigNumber);
            Console.WriteLine(letra);
            Console.WriteLine(palabra);
            Console.WriteLine(realNumber);
            Console.WriteLine(dobleNumber);
            Console.WriteLine(precisionNumber);
            Console.WriteLine(flag);
        }
    }
}
