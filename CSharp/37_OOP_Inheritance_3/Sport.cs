using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance_3
{
    internal class Sport : Araba
    {
        public bool Cabrio { get; set; }

        public void ArabaBilgileri()
        {
            base.ArabaBilgileri();
            Console.WriteLine($"Cabrio: {Cabrio}");
        }
    }
}
