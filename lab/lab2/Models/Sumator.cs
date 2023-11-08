using System;
using System.Collections.Generic;
using System.Text;

namespace lab2.Models
{
    class Sumator
    {
        public int[] Liczby;
        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int Suma()
        {
            var result = 0;
            for (var i = 0; i < Liczby.Length; i++)
            {
                var liczba = Liczby[i];
                result += liczba;
            }
            return result;
        }
        public int SumaPodziel3()
        {
            var result = 0;
            for (var i = 0; i < Liczby.Length; i++)
            {
                var liczba = Liczby[i];
                if (liczba % 3 == 0)
                    result += liczba;
            }
            return result;
        }
        public int IleElementów()
        {
            return Liczby.Length;
        }

        public void DisplayLiczby()
        {
            for (var i = 0; i < Liczby.Length; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }

        public void DisplayLiczby(int lowIndex, int highIndex)
        {
            lowIndex = lowIndex < 0 ? 0 : lowIndex;
            highIndex = highIndex > Liczby.Length ? Liczby.Length : highIndex;

            for (var i = lowIndex; i < highIndex; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }
    }
}
