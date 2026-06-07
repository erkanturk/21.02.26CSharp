using System;
using System.Collections.Generic;
using System.Text;

namespace _38_OOP_Partial_Class
{
    internal partial class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Adres { get; set; }
        public Personel(string ad)
        {
            Console.WriteLine("Personel Sınıfı Ctoru");
        }
    }
}
