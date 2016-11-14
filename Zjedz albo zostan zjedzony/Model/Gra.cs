using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjedz_albo_zostan_zjedzony.Model
{
    public class Gra
    {
        public Plansza PlanszaGry { get; set; }

        public Wlasciwosci WlasciwosciGry { get; set; }

        public List<Pole> Puste { get; set; }

        public List<Pole> Zajete { get; set; }
    }
}
