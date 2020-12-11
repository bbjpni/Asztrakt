using System;
using System.Collections.Generic;
using System.Text;

namespace Asztrakt
{
    abstract class  Gepjarmu
    {
        //BENZIN V. DIZEL
        protected bool uzemanyag;
        protected int kerekekSzama;
        protected string rendszam;

        protected Gepjarmu(bool uzemanyag, int kerekekSzama, string rendszam)
        {
            this.uzemanyag = uzemanyag;
            this.kerekekSzama = kerekekSzama;
            this.rendszam = rendszam.ToUpper();
        }

        public override string ToString()
        {
            return String.Format("rendszám: {0}\nüzemanyag: {1}\nkerekek száma: {2}", this.rendszam, this.uzemanyag ? "benzines" : "dizel", this.kerekekSzama);
        }
    }
}
