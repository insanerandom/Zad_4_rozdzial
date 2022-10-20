using System;

namespace zDSR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 4.1");
            Console.WriteLine("Ile chcesz wpisac liczb?");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[rozmiar];
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Podales nastepujace liczby:");
            foreach (int x in liczby)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nZadanie 4.2");
            int[] tab1 = { -5, 65, 42, -8, 96, -90, -2, -777, 32, 54 };
            int[] tab2 = new int[10];
            int j = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] >= 0)
                {
                    tab2[j] = tab1[i];
                    j++;
                }
            }
            foreach (int x in tab2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nZadanie 4.3");
            int suma = 0, counter = 0, rememberPosMax = 0, rememberPosMin = 0;
            int max = liczby[0];
            int min = liczby[0];
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] > max)
                {
                    max = liczby[i];
                    rememberPosMax = i;
                }
            }
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] < min)
                {
                    min = liczby[i];
                    rememberPosMin = i;
                }
            }
            for (int i = 0; i < liczby.Length; i++)
            {
                suma += liczby[i];
            }
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] >= 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("Najwiekszy element jest na pozycji {0} i jest to liczba {1}", rememberPosMax, max);
            Console.WriteLine("Najmniejszy element jest na pozycji {0} i jest to liczba {1}", rememberPosMin, min);
            Console.WriteLine("Suma wszystkich liczb: {0}", suma);
            Console.WriteLine("Liczba wszystkich liczb dodatnich: {0}", counter);
            Console.WriteLine("\nZadanie 4.4");
            Random rand = new Random();
            int[] rLiczba = new int[100];
            int random = 0;
            int counter_ = 0;
            int ileLiczbPierwszych = 0;
            for (int i = 0; i < rLiczba.Length; i++)
            {
                random = rand.Next(1, 1000);
                rLiczba[i] = random;
                Console.Write("{0,8}", random);
            }
            for (int i = 0; i < rLiczba.Length; i++)
            {
                for (int k = rLiczba[i]; k > 0; k--)
                {
                    if (rLiczba[i] % k == 0)
                    {
                        counter_++;
                    }
                    if (counter_ > 2)
                    {
                        break;
                    }
                }
                if (counter_ <= 2 && rLiczba[i] != 1 && rLiczba[i] != 0)
                {
                    ileLiczbPierwszych++;
                }
                counter_ = 0;
            }
            Console.WriteLine("\nLiczb pierwszych jest: {0}", ileLiczbPierwszych);
            Console.ReadKey();
        }
    }
}
