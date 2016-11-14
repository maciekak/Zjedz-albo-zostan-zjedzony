using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjedz_albo_zostan_zjedzony.Model
{
    public class Wlasciwosci
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int CzestotliwoscDodawania { get; set; }

        public int CzestotliwoscDwojki { get; set; }

        public int MinimalnaPustych { get; set; }

        public int PromienPolowania { get; set; }

        public int PromienUcieczki { get; set; }
    }
}
