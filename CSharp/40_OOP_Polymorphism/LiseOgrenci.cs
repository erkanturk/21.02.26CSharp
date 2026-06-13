using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism
{
    internal class LiseOgrenci:Ogrenci
    {
        public override void Kaydet()
        {
            Ad = "Erkan";
            Soyad = "Türk";
            Yas = 32;
            Numara = 10;
        }
    }
}
