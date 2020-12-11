using System;
using System.Collections.Generic;
using System.Text;

namespace Asztrakt
{
    class Motor : Gepjarmu
    {
        public Motor(string rendszam, bool uzemanyag)
            : base(uzemanyag, 2, rendszam)
        {
        }

        public override string ToString()
        {
            return "MOTOR:\n"+base.ToString();
        }
    }
}
