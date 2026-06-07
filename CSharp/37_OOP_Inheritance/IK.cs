using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance
{
    internal class IK: Personel//':' İnheritance kalımım almayı temsil eder
    {
        public int PersonelSayisi { get; set; }

        public new void PersonelBilgileri()//personel sınıfındaki personel bilgileri metodunu ezmek için new keywordu kullanılır
        {
            base.PersonelBilgileri();//base anahtar kelimesi ile personel sınıfındaki personel bilgileri metodunu çağırırız
            Console.WriteLine($"Personel Sayısı: {PersonelSayisi}");
        }
    }
}
