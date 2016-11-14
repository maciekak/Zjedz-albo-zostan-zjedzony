using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zjedz_albo_zostan_zjedzony.Model;

namespace Zjedz_albo_zostan_zjedzony.View
{
    public static class Rysowanie
    {
        public static void Rysuj(Plansza plansza)
        {
            var wysokosc = plansza.WszystkiePola.Count;
            var firstOrDefault = plansza.WszystkiePola.FirstOrDefault();
            if (firstOrDefault == null) return;

            var szerokosc = firstOrDefault.Count;

            for (var i = 0; i < szerokosc +2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            for (var i = 0; i < wysokosc; i++)
            {
                Console.Write('|');
                for (var j = 0; j < szerokosc; j++)
                {
                    Console.Write(plansza.WszystkiePola[i][j].Znak);
                }
                Console.Write('|');
                Console.WriteLine();
            }

            for (var i = 0; i < szerokosc +2; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }
}
