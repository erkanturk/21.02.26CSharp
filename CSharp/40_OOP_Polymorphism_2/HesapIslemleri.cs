using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism_2
{
    internal class HesapIslemleri
    {
        public virtual void ParaGonder(int tutar)
        {
            const double kdv = 1.20;
            Console.WriteLine($"{tutar * kdv} Havale yıldı");
        }

    }
}
