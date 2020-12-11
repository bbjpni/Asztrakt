using System;
using System.Collections.Generic;
using System.Text;

namespace Asztrakt
{
    class Busz : Gepjarmu
    {
        public Busz(int kerekekSzama, string rendszam)
            : base(false, kerekekSzama, rendszam)
        {
        }

        public override string ToString()
        {
            return "BUSZ:\n" + base.ToString();
        }
    }
}
