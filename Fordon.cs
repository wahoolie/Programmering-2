using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmering
{
    class Fordon
    {
        private string Namn;
        private string Modell;
        private string Färg;

        public Fordon(string N, string M, string F)
        {
            Namn = N;
            Modell = M;
            Färg = F;
        }

        public Fordon() { }

        public string namn
        {
            get{ return Namn; }
            set{ Namn = value; }
        }

        public string modell
        {
            get{ return Modell; }
            set{ Modell = value; }
        }

        public string färg
        {
            get{ return Färg; }
            set{ Färg = value; }
        }
        
    }
}