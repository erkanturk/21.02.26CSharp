using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance
{
    internal class Personel//base class 
    {
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Yas { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string SigortaNo { get; set; }

        public void PersonelBilgileri()
        {
            Console.WriteLine($"TC: {TC}");
            Console.WriteLine($"Ad Soyad: {AdSoyad}");
            Console.WriteLine($"Adres: {Adres}");
            Console.WriteLine($"Yaş: {Yas}");
            Console.WriteLine($"İşe Giriş Tarihi: {IseGirisTarihi.ToShortDateString()}");
            Console.WriteLine($"Sigorta No: {SigortaNo}");
        }
    }
}
