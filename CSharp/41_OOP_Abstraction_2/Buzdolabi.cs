using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction_2
{
    internal class Buzdolabi : Elektirikli
    {
        public override int Amper { get ; set ; }
        public override double AlisFiyati { get ; set ; }
        public override double KarYuzdesi { get; set ; }
        public string renk {  get; set; }

        public override double FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;
        }
        public Buzdolabi()
        {
            
        }
    }
}
