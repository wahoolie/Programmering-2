using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Fordon
    {
        private string Namn;
        private string Modell;
        private string Färg;

        public void setNamn(string n) { Namn = n;}
        public string getNamn() { return Namn;}
        public void setModell(string m) { Modell = m;}
        public string getModell() { return Modell;}
        public void setFärg(string f) { Färg = f;}
        public string getFärg() { return Färg;}
    }
}