using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism_2
{
    internal class Swift:HesapIslemleri
    {
        public override void ParaGonder(int tutar)
        {
            const double kdv = 1.55;
            Console.WriteLine($"{tutar*kdv} swift yapıldı");
        }
    }
}
