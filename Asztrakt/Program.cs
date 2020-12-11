using System;
using System.Collections.Generic;

namespace Asztrakt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gepjarmu> lista = new List<Gepjarmu>();
            lista.Add(new Motor("aaa-000", true));
            lista.Add(new Szemelyauto(false, "tibi-069"));
            lista.Add(new Busz(6, "BKK-123"));
            lista.Add(new Munkagep(false, 3, "FArm-667"));

            foreach (Gepjarmu item in lista)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
