using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmering
{
    class Fordonlista
    {
        private List<Fordon> fordonlista = new List<Fordon>();

        public void nyttFordon()
        {
            string nyttNamn;
            string nyModell;
            string nyFärg;
            Console.WriteLine("Ange Namn på Bilen: ");
            nyttNamn = Console.ReadLine();
            Console.WriteLine("Ange Modell: ");
            nyModell = Console.ReadLine();
            Console.WriteLine("Ange Färg: ");
            nyFärg = Console.ReadLine();
            Fordon nyttFordon = new Fordon(nyttNamn, nyModell, nyModell);
            fordonlista.Add(nyttFordon);
        }

        public void skrivUt()
        {
            foreach (Fordon element in fordonlista)
            {
                Console.WriteLine(element.namn);
                Console.WriteLine(element.modell);
                Console.WriteLine(element.färg);
            }
        }

    }

}