using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjedz_albo_zostan_zjedzony.Model
{
    public class Pole
    {
        public Rodzaj Symbol { private get; set; }

        public Pole(Rodzaj symbol = Rodzaj.Puste)
        {
            Symbol = symbol;
        }

        public char Znak => Convert.ToChar(Symbol);
    }

    public enum Rodzaj
    {
        Puste = '.', Jedynka = '1', Dwojka, Trojka, Czworka, Piatka, Szostka
    }
}
