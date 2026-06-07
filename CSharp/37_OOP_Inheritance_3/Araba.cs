using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance_3
{
    internal class Araba
    {
        public int ArabaID { get; set; }
        public string ArabaMarka { get; set; }
        public string ArabaModel { get; set; }
        public string YakitTuru { get; set; }
        public string Vites { get; set; }
        public string Renk { get; set; }

        public void ArabaBilgileri()
        {
            Console.WriteLine($"Araba Markası: {ArabaMarka}");
            Console.WriteLine($"Araba Modeli: {ArabaModel}");
            Console.WriteLine($"Yakıt Türü: {YakitTuru}");
            Console.WriteLine($"Vites: {Vites}");
            Console.WriteLine($"Renk: {Renk}");
        }
    }
}
