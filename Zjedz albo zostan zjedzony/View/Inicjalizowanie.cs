using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zjedz_albo_zostan_zjedzony.Model;

namespace Zjedz_albo_zostan_zjedzony.View
{
    public static class Inicjalizowanie
    {
        public static Wlasciwosci Dane { get; set; }

        public static void Pobierz()
        {
            Dane = new Wlasciwosci();

            Console.WriteLine("Wczytywanie danych");

            Rozmiar();
            Dodawanie();
            WolnePola();
            ZasiegSprawdzania();
        }

        private static void Rozmiar()
        {
            int doWczytywania;

            Console.WriteLine("Wielkosc planszy:");
            Console.Write("X = ");

            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.X = doWczytywania;

            Console.Write("Y = ");
            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.Y = doWczytywania;

            Console.WriteLine();
        }

        private static void Dodawanie()
        {
            Console.WriteLine("Dodawanie:");

            int doWczytywania;

            Console.Write("Czestotliwosc dodawania nowych cyfr(1/n): ");
            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.CzestotliwoscDodawania = doWczytywania;

            Console.Write("Srednio na ile dodan dodac dwojke: ");
            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.CzestotliwoscDwojki = doWczytywania;

            Console.WriteLine();

        }

        private static void WolnePola()
        {
            Console.WriteLine("Minimalna ilosc wolnych pol:");
            int doWczytywania;

            Console.Write("Podaj ile minimalnie musi byc pustych pol: ");
            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.MinimalnaPustych = doWczytywania;

            Console.WriteLine();
        }

        private static void ZasiegSprawdzania()
        {
            Console.WriteLine("Dlugosci zasiegow: ");
            int doWczytywania;

            Console.Write("Podaj promien szukania ofiar: ");
            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.PromienPolowania = doWczytywania;

            Console.Write("Podaj promien uciekania od agresora: ");
            int.TryParse(Console.ReadLine(), out doWczytywania);
            Dane.PromienUcieczki = doWczytywania;

            Console.WriteLine();

        }
    }
}
