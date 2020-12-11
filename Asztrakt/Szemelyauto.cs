using System;
using System.Collections.Generic;
using System.Text;

namespace Asztrakt
{
    class Szemelyauto : Gepjarmu
    {
        public Szemelyauto(bool uzemanyag, string rendszam)
            : base(uzemanyag, 4, rendszam)
        {
        }

        public override string ToString()
        {
            return "SZEMÉLYAUTÓ:\n" + base.ToString();
        }
    }
}
