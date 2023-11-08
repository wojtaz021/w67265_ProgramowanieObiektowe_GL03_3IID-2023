using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                Console.WriteLine("Wybierz funkcje:");
                Console.WriteLine("1. Liczba parzysta");
                Console.WriteLine("2. N liczb parzystych");
                Console.WriteLine("4. Silnia");
                Console.WriteLine("5. Gra");
                Console.WriteLine("0. Wyjdź");

                var input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        DisplayNumberIsEven();
                        break;
                    case 2:
                        wypisz();
                        break;
                    case 4:
                        silnia();
                        break;
                    case 5:
                        gra();
                        break;

                    case 0:
                        return;
                }
            }
            Console.ReadKey();
        }

        public static void DisplayNumberIsEven()
        {
            Console.WriteLine("podaj liczbe: ");
            var input = Console.ReadLine();

            int liczba = int.Parse(input);
            if (liczba % 2 == 0)
            {
                Console.WriteLine("parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
        }
        public static void wypisz()
        {
            Console.WriteLine("podaj liczbe: ");
            var input = Console.ReadLine();

            int liczba = int.Parse(input);
            int i = 1;
            while(i <= liczba)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            
          
        }

        public static void silnia()
        {
            Console.WriteLine("Podaj liczbe");
            var input = Console.ReadLine();

            int number = int.Parse(input);
            var answer = 1;

            for (int i = 1; i<=number; i++)
            {
                answer = answer * i;
            }
            Console.WriteLine(answer);
        }

        public static void gra()
        {
            Random rnd = new Random();
            int kox = rnd.Next(1, 10);

            while(true)
            {
                Console.WriteLine("Podaj liczbe: ");
                var input = Console.ReadLine();

                int shoot = int.Parse(input);
                int proby = 0;

                if (shoot > kox)
                {
                    Console.WriteLine("za duża");
                    proby++;
                }
                else if (shoot < kox)
                {
                    Console.WriteLine("za mała");
                    proby++;
                }
                else
                {
                    Console.WriteLine("dobra liczba");
                    Console.WriteLine("liczba prob", proby);
                    break;
                }
            }
            
        }


    }
}
