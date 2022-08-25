using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        public static void Main()
        {
            Fordon S = new Fordon();
            S.setNamn("Tesla");
            S.setModell("Model S");
            S.setFärg("Röd");

            Fordon Y = new Fordon();
            Y.setNamn("Tesla");
            Y.setModell("Model Y");
            Y.setFärg("Vit");
        }
    }
}