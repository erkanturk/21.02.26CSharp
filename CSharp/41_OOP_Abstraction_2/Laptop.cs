using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction_2
{
    internal class Laptop : Elektirikli//, Sarjli//Bir sınıf yalnızca bir sınıfı miras alabilir. birden fazla sınıfı miras alamaz.
    {
        public override int Amper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double AlisFiyati { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double KarYuzdesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
