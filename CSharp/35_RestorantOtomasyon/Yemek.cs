using System;
using System.Collections.Generic;
using System.Text;

namespace _35_RestorantOtomasyon
{
    public class Yemek
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public double Fiyat { get; set; }
        public string Tip { get; set; }

        public static List<Yemek> Menu = new List<Yemek>()
        {
            new Yemek(){Id=1,Isim="Mercimek",Fiyat=150,Tip="çorba" },
            new Yemek(){Id=2,Isim="Ezogelin",Fiyat=150,Tip="çorba" },
            new Yemek(){Id=3,Isim="Bolonez Makarna",Fiyat=350,Tip="makarna" },
            new Yemek(){Id=4,Isim="Köri Makarna",Fiyat=350,Tip="makarna" },
            new Yemek(){Id=5,Isim="Mezgit",Fiyat=550,Tip="balık" },
            new Yemek(){Id=6,Isim="Levrek",Fiyat=650,Tip="balık" },
            new Yemek(){Id=7,Isim="Lokum",Fiyat=1000,Tip="et" },
            new Yemek(){Id=8,Isim="Biftek",Fiyat=1100,Tip="et" },
            new Yemek(){Id=9,Isim="Kola",Fiyat=150,Tip="içecek" },
            new Yemek(){Id=10,Isim="Şalgam",Fiyat=150,Tip="içecek" },
        };
        public static void MenuYaz()
        {
            Console.WriteLine("********** Menü **********");
            foreach (Yemek yemek in Menu)
            {
                Console.WriteLine($"Id:{yemek.Id} İsim:{yemek.Isim} Fiyat:{yemek.Fiyat} Tip:{yemek.Tip}");
            }
        }
        
        public static void MenuDuzenle()
        {
            MenuYaz();
            Console.WriteLine("Güncellenecek yemek numarası:");
            int id = Convert.ToInt32(Console.ReadLine());
            Yemek update = Menu.FirstOrDefault(i => i.Id == id);
            if (update != null)
            {
                Console.WriteLine("İsim");
                update.Isim = Console.ReadLine();
                Console.WriteLine("Fiyat");
                update.Fiyat = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tip");
                update.Tip = Console.ReadLine();
                Console.WriteLine("Güncellendi.");
            }
            else
            {
                Console.WriteLine("Yetkiniz bulunmamaktadır.");
            }
        }
    }
}
