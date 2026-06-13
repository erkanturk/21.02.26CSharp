using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction_2
{
    internal abstract class Elektronik
    {
        protected Elektronik()//Sadece miras alınması durumunda çalışacak ctor yapısı.
        {
            Console.WriteLine("Sadece mirasla çalışacak");
        }
        public abstract double AlisFiyati { get; set; }
        public abstract double KarYuzdesi { get; set; }

        public abstract double FiyatHesapla();
    }
}
