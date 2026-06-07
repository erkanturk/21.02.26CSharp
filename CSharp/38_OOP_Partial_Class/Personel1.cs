using System;
using System.Collections.Generic;
using System.Text;

namespace _38_OOP_Partial_Class
{
    internal partial class Personel
    {
        public Personel()
        {
            Console.WriteLine("Personel1 ctoru");
        }
        public void OzellikleriGoster()
        {
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Soyad: {Soyad}");
            Console.WriteLine($"Yaş: {Yas}");
            Console.WriteLine($"Adres: {Adres}");
        }
    }
}
