using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance
{
    internal class Muhasebe:Personel
    {
        public string HesapSayisi { get; set; }
        public void PersonelBilgileri()
        {
            base.PersonelBilgileri();
        }

    }
}
