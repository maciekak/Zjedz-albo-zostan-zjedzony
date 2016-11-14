using System;
using Zjedz_albo_zostan_zjedzony.Model;
using Zjedz_albo_zostan_zjedzony.View;

namespace Zjedz_albo_zostan_zjedzony.Controller
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Inicjalizowanie.Pobierz();
            var plansza = new Plansza(Inicjalizowanie.Dane.X, Inicjalizowanie.Dane.Y);
            Rysowanie.Rysuj(plansza);
            
            Console.ReadKey();
        }
        
    }
}
