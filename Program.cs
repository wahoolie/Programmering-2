using System;

namespace Programmering // Note: actual namespace depends on the project name.
{
    class Program
    {
        public static void Main(string [] args)
        {
            int menyval = 1;
            Fordonlista f1 = new Fordonlista();
            while(menyval != 0)
            {
                Console.WriteLine("Fordonsregister");
                Console.WriteLine("================");
                Console.WriteLine("1. Registreara Nytt Fordon");
                Console.WriteLine("2. Skriv ut alla Fordon i listan");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine("Ange ditt val: ");
                menyval = Convert.ToInt32(Console.ReadLine());
                if (menyval == 1)
                    f1.nyttFordon();
                else if (menyval == 2)
                    f1.skrivUt();

            }
        }
    }
}