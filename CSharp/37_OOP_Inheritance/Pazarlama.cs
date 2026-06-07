using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance
{
    internal class Pazarlama: Personel//child class
    {
        public int MusteriSayisi { get; set; }
        public void PersonelBilgileri()
        {
            base.PersonelBilgileri();
            Console.WriteLine($"Müşteri Sayısı: {MusteriSayisi}");
        }
        
    }
}
