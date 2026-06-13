using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism_2
{
    internal class Havale:HesapIslemleri
    {
        public override void ParaGonder(int tutar)
        {
            base.ParaGonder(tutar);
        }
    }
}
