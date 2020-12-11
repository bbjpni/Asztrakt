using System;
using System.Collections.Generic;
using System.Text;

namespace Asztrakt
{
    class Munkagep : Gepjarmu
    {
        public Munkagep(bool uzemanyag, int kerekekSzama, string rendszam)
            : base(uzemanyag, kerekekSzama, rendszam)
        {
        }

        public override string ToString()
        {
            return "MUNKAGÉP:\n" + base.ToString();
        }
    }
}
