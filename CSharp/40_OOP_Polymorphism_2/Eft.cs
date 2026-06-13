using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism_2
{
    internal class Eft:HesapIslemleri
    {
        public override void ParaGonder(int tutar)
        {
            const double kdv = 1.35;
            Console.WriteLine($"{tutar*kdv} eft yapıldı");
        }
    }
}
