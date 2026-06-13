using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction
{
    public class Ogrenci : Insan
    {
        public override long TC { get ; set ; }
        public override string Ad { get; set; }
        public string Bolum { get; set; }

        public override void Create(long tc)
        {
           

            TC = tc;
            Console.WriteLine("Bolüm");
            Bolum = Console.ReadLine();
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
        }

        public override void Delete()
        {
           
        }

        public override void List()
        {
            
        }

        public override void Update()
        {
           
        }
    }
}
