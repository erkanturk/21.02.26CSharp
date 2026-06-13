using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction_2
{
    internal class Telefon : Sarjli
    {
        public override double MiliAmperSaat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double AlisFiyati { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double KarYuzdesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MGP { get; set; }

        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
