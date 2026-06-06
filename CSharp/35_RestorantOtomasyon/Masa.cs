using System;
using System.Collections.Generic;
using System.Text;

namespace _35_RestorantOtomasyon
{
    public class Masa
    {
        public int Id { get; set; }
        public bool Dolu { get; set; }
        public List<Siparis> Siparisler { get; set; }
        public Masa()//constructor method yapıcı method
        {
            Siparisler = new List<Siparis>();
            // Masa sınıfından bir nesne oluşturulduğunda
            // Siparisler listesi de otomatik olarak oluşturulacak ve boş olarak gelecektir.
        }
        public static Masa MasaDoldur(List<Masa> liste)
        {
            foreach (Masa masa in liste)
            {
                if (!masa.Dolu)
                {
                    masa.Dolu = true;
                    return masa;
                }
            }
            return null;
        }
        public static void DoluMasa(List<Masa> liste)
        {
            foreach (Masa masa in liste)
            {
                if (masa.Dolu)
                {
                    Console.WriteLine($"Dolu Masa Id:{masa.Id}");
                }
            }
        }

    }
}
