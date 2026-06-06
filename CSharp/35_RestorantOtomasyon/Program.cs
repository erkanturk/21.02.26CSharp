namespace _35_RestorantOtomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ******** RESTAURANT OTOMASYONU **********
            
            Toplam 5 Masa olacak
            ANAMENU
            1-Sipariş Al
            2-Hesap Al
            3-Menü Düzenle
            4-Çıkış
            
            Her gelen müşteri ilk boş masaya oturtulacak
            Kaç kişisiniz diye sorulacak ve her kişiye ayrı ayrı menü yazdırılarak yemek seçmesi istenecek.
            Yemek seçimi sonrası başka bir arzunuz var mı diye sorulacak.
            Evet -> Tekrar menü yazdır ve yemek siparişi al
            Hayır -> 1.masa 2. müşteri için aynı işlemleri yap
            Masadaki herkesin siparişi alındıysa tekrar ana menüye dön   
             */

            List<Masa> masalar = new List<Masa>()
            {
                new Masa(){Id=1,Dolu=false },
                new Masa(){Id=2,Dolu=false },
                new Masa(){Id=3,Dolu=false },
                new Masa(){Id=4,Dolu=false },
                new Masa(){Id=5,Dolu=false },
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Sipariş Al\n2-Hesap Al\n3-Menü Düzenle\n4-Çıkış\nSeçiminiz:");
                int secim;
                if ((int.TryParse(Console.ReadLine(), out secim)) && secim > 0 && secim < 5)
                {
                    if (secim == 1)
                    {
                        Masa musteriMasa = new Masa();
                        Console.WriteLine("Kaç Kişisiniz");
                        int kisiSayisi=Convert.ToInt32(Console.ReadLine());
                        musteriMasa=Masa.MasaDoldur(masalar);
                        if (musteriMasa == null)
                        {
                            Console.WriteLine("Maalesef Doluyuz...");
                            Thread.Sleep(2000);
                            continue;
                        }
                        int i = 1;
                        while (kisiSayisi >= i)
                        {
                            musteriMasa.Siparisler.Add(Siparis.SiparisAl(musteriMasa.Id));
                            Console.WriteLine("Başka bir arzunur var mı ? (E/H)");
                            bool cevap =Console.ReadLine().ToUpper() == "E" ? true : false;
                            if (!cevap)
                            {
                                Console.Clear();
                                i++;
                            }

                        }

                    }
                    else if (secim == 2)
                    {
                        Masa.DoluMasa(masalar);
                        Siparis.HesapAl(masalar);
                    }
                    else if (secim == 3)
                    {
                        Yemek.MenuDuzenle();
                    }
                    else if (secim == 4)
                    {
                        Console.WriteLine("Uygulama kapanıyor gün sonu almayı unutma");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.ForegroundColor = (ConsoleColor)i;
                            Console.WriteLine($"{i}");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.ResetColor();


                        }
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Seçiminiz 1 ila 4 arasında olmalıdır.");
                    }
                }
            }
        }
    }
}
