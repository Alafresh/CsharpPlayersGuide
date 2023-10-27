using System;

namespace TheDominionOfKings
{
    class Program
    {
        static void Main(string[] args)
        {
            int provinces, duchies, estates, estatesPoint = 0, duchiesPoint = 0, provincesPoint = 0, melik = 0, casik = 0, balik = 0;
            string king;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    king = "Melik";
                else if (i == 1)
                    king = "Casik";
                else
                    king = "Balik";
                Console.WriteLine("{0}'s Provinces", king);
                provinces = Convert.ToInt32(Console.ReadLine());
                provincesPoint = provinces;
                Console.WriteLine("{0}'s Duchies", king);
                duchies = Convert.ToInt32(Console.ReadLine());
                duchiesPoint = duchies;
                Console.WriteLine("{0}'s Estates", king);
                estates = Convert.ToInt32(Console.ReadLine());

                estatesPoint = estates + estates;
                for (int j = 0; j < duchies; j++) 
                {
                    duchiesPoint += 3;
                }
                for (int l = 0; l < provinces; l++)
                {
                    provincesPoint += 6;
                }
                if (i == 0)
                {
                    Console.WriteLine("{0} province, {1} estate, duchies {2}", provincesPoint, estatesPoint, duchiesPoint);
                    melik = provincesPoint + estatesPoint + duchiesPoint;
                }
                else if (i == 1)
                    casik = provincesPoint + estatesPoint + duchiesPoint;
                else
                    balik = provincesPoint + estatesPoint + duchiesPoint;
            }
            Console.WriteLine("Melik points {0}, Casik points {1}, Balik points {2}", melik, casik, balik);
        }
    }
}
