using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism
{
    internal class Ogretmen:Insan
    {
        public string Brans {  get; set; }
        public int OgrenciSayisi { get; set; }
        public override void Kaydet()
        {
            Console.WriteLine("Brans");
            Brans = Console.ReadLine();
            Console.WriteLine("Öğrenci Sayısı");
            OgrenciSayisi = Convert.ToInt32(Console.ReadLine());

        }
    }
}
