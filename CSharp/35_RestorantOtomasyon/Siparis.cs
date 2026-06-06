using System;
using System.Collections.Generic;
using System.Text;

namespace _35_RestorantOtomasyon
{
    public class Siparis
    {
        public int Id { get; set; }
        public int MasaId { get; set; }//Foreign key
        public Yemek Yemek { get; set; }//Navigation property

        public static Siparis SiparisAl(int masaId)
        {
            Siparis siparis = new Siparis();
            Yemek.MenuYaz();
            Console.WriteLine("İstediğiniz yemek numarası");
            int secim= Convert.ToInt32(Console.ReadLine());
            siparis.Yemek = Yemek.Menu.FirstOrDefault(i => i.Id == secim);
            if (siparis.Yemek == null)
            {
                Console.Clear();
                Console.WriteLine("Hatalı yemek seçimi");
                Siparis.SiparisAl(masaId);
            }
            siparis.MasaId = masaId;

            return siparis;
        }
        public static void HesapAl(List<Masa> liste)
        {
            Console.WriteLine("Hesap alınacak masa numarası:");
            int masaNo= Convert.ToInt32(Console.ReadLine().Replace("Dolu Masa Id:",""));
            Masa masa = liste.FirstOrDefault(i => i.Id == masaNo);
            double hesap = 0;
            foreach (Siparis siparis in masa.Siparisler)
            {
                hesap += siparis.Yemek.Fiyat;
            }
            Console.WriteLine("Hesap:" + hesap);
            Console.WriteLine("Hesap Bölünsün mü ? (E/H)");
            string bol = Console.ReadLine().ToUpper();
            if (bol == "E")
            {
                Console.WriteLine("Hesap kaça bölünsün ?");
                int bolme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Kişi başı ödenecek tutar:{hesap / bolme}");
            }
            Console.WriteLine("Hesap ödendi mi ? (E/H)");
            bool odeme = Console.ReadLine().ToUpper() == "E" ? true : false;
            if (odeme)
            {
                masa.Dolu = false;
                masa.Siparisler.Clear();
                Console.WriteLine("Ödeme başarılı iyi günler");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Mutfağı gösterin arkadaşa");
                Thread.Sleep(2000);
            }

        }

    }
}
