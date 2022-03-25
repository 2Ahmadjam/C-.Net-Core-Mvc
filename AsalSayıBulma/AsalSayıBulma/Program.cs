using System;

namespace AsalSayıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------- 1_10000 Arasında Asal Sayılar ------------------------------- ");
            int kontrol = 0;
            int sayac = 0;
            for (int i = 2; i <= 10000; i++)
            {
                kontrol = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    sayac++;
                    Console.Write(i + "-");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Adet :"+ sayac);
            Console.ReadKey();
        }
    }
}
