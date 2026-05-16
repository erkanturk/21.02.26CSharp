using System;
using System.Collections.Generic;
using System.Text;

namespace _32_Class_Object
{
    internal class Ogretmen
    {
        internal int OgretmenNo { get; set; } = 0;
        public string OgretmenAd { get; set; } = string.Empty;
        internal protected string OgretmenSoyad { get; set; } = string.Empty;
        private int Tel { get; set; } = 0;

        //init yapısı Record yapılarında kullanılan bir yapıdır. Ancak normal sınıflarda da kullanılabilirler.
        public string Bolum { get; init; } = "";
        //İnit yapısı sadece nesne oluşturulurken değer ataması yapılmasına izin verir. Yani bir kez atandıktan sonra değeri değiştirilemez.
        public void OgretmenBilgileri()
        {
            Console.WriteLine($"Öğretmen No: {OgretmenNo}");
            Console.WriteLine($"Öğretmen Ad: {OgretmenAd}");
            Console.WriteLine($"Öğretmen Soyad: {OgretmenSoyad}");
            Console.WriteLine($"Telefon: {Tel}");
            //Tel=int.Parse(Console.ReadLine());
        }
    }
}
