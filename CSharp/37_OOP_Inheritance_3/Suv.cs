using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance_3
{
    internal class Suv:Araba
    {
        public bool DortCeker { get; set; }
        public void ArabaBilgileri()
        {
            base.ArabaBilgileri();
            Console.WriteLine($"4 Çeker: {DortCeker}");
        }
    }
}
