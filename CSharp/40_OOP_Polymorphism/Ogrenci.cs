using System;
using System.Collections.Generic;
using System.Text;

namespace _40_OOP_Polymorphism
{
    internal class Ogrenci:Insan
    {
        public int Numara {  get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public void NotAl()
        {
            Console.WriteLine("Vize");
            Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final");
            Final = Convert.ToInt32(Console.ReadLine());
        }
        public override void Kaydet()//Ezme işlemi
        {
            base.Kaydet();//Anasınıftaki değerleri al ve üstüne bu değerleri de ekle
            Console.WriteLine("Numara");
            Numara= Convert.ToInt32(Console.ReadLine());
            NotAl();
        }
    }
}
