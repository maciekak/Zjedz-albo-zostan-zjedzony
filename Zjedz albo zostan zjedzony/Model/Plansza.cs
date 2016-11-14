using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjedz_albo_zostan_zjedzony.Model
{
    public class Plansza
    {
        public List<List<Pole>> WszystkiePola { get; set; }

        public Plansza(int x, int y)
        {
            WszystkiePola = new List<List<Pole>>();

            //TODO: zamienic na LINQ
            for (var i = 0; i < y; i++)
            {
                WszystkiePola.Add(new List<Pole>());
                for (var j = 0; j < x; j++)
                {
                    WszystkiePola.Last().Add(new Pole());
                }
            }
        }
    }
}
