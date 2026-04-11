namespace _13_OtomatProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proje
            /* 

          Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
         Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği
         ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
         satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
            var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
          */
            #endregion

            #region Otomat Projesi
            bool admin = false;
            string pass = "123";
            string adminPass;
            int hak = 0;
            bool hesapKilit = false;
            string[] urunler = { "kola", "fanta", "sprite", "ayran", "cips" };
            double[] fiyatlar = { 60, 55, 65, 45, 70 };
            double bakiye = 0;

            while (true)
            {
                try
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i}. {urunler[i]} - {fiyatlar[i]} TL");
                    }
                    Console.WriteLine("Ürün numarası seçiniz (Admin girişi için -1 e basınız)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo == -1)
                    {
                        // Admin girişi işlemleri
                        Console.Clear();
                        if (!hesapKilit)
                        {
                            while (hak < 3)
                            {
                                Console.WriteLine("Admin Şifrenizi giriniz");
                                adminPass = Console.ReadLine();
                                if (adminPass == pass)
                                {
                                    admin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    hak++;
                                    Console.WriteLine("Yanlış şifre kalan hakkınız:" + (3 - hak));

                                }
                                if (hak == 3)
                                {
                                    Console.WriteLine("Çok sayıda hatalı işlem yapıldı sistem 10 saniye kitlendi");
                                    hesapKilit = true;
                                    Thread.Sleep(10000);
                                    hesapKilit = false;
                                    hak = 0;
                                    continue;
                                }
                            }
                            Console.Clear();
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Hesap kilitli, lütfen 10 saniye bekleyin.");
                            Thread.Sleep(10000);
                            hesapKilit = false;
                        }
                        continue;
                    }
                    Console.WriteLine("Para girişi yapınız");
                    bakiye = Convert.ToDouble(Console.ReadLine());
                    if (bakiye >= fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız.\nAfiyet olsun.\nPara Üstü: " + (bakiye - fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        bakiye = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz bakiye");
                            Console.WriteLine("1-Para Ekle\n2-Para İade");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Para Ekle");
                                bakiye += Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız.\nAfiyet olsun.\nPara Üstü: " + (bakiye - fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    bakiye = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Para İade Edildi" + bakiye);
                                bakiye = 0;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                        }
                      
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hatalı işlem" + ex.Message);
                    Thread.Sleep(2000);
                    throw;
                }

            }
            if (admin)
            {
                while (true)
                {
                    
                    Console.Clear();
                    Console.WriteLine("Admin Panel");
                    Console.WriteLine("1-Ürün ekleme\n2-Güncelleme\n3-Silme\n4-Listeleme\n5-Çıkış ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Ürün Adı:");
                        string urunAdi = Console.ReadLine().ToLower();
                        bool kontrol = false;

                        for (int i = 0; i < urunler.Length; i++)
                        {
                            if (urunler[i].ToLower() == urunAdi)
                            {
                                kontrol = true;
                                break;
                            }
                        }
                        if (kontrol)
                        {
                            Console.WriteLine("Ürün zaten mevcut");
                            Thread.Sleep(2000);
                            continue;
                        }
                        Console.WriteLine("Ürün fiyatı:");
                        double fiyat = Convert.ToDouble(Console.ReadLine());
                        Array.Resize(ref urunler, urunler.Length + 1);//Dizinin boyutunu 1 artırdık
                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                        urunler[urunler.Length - 1] = urunAdi;//var olan dizinin eleman sayınının -1 değeri index değeridir.
                        fiyatlar[fiyatlar.Length - 1] = fiyat;
                        Console.WriteLine("Ürün eklendi");
                        Thread.Sleep(2000);
                    }
                    else if (secim == 2)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i}. {urunler[i]} - {fiyatlar[i]} TL");
                        }
                        Console.WriteLine("Güncellenecek ürün numarası:");
                        string guncelle = Console.ReadLine().ToLower();
                        int index;
                        if (int.TryParse(guncelle, out index))
                        {
                            if (index >= 0 && index < urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı:");
                                string yeniUrun = Console.ReadLine().ToLower();
                                Console.WriteLine("Yeni Fiyat:");
                                double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[index] = yeniUrun;
                                fiyatlar[index] = yeniFiyat;
                                Console.WriteLine("Ürün Güncellendi");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                        else
                        {
                            int i = Array.IndexOf(urunler, guncelle);

                            if (i >= 0 && i < urunler.Length)
                            {
                                Console.WriteLine("Yeni ürün adı:");
                                string yeniUrun = Console.ReadLine().ToLower();
                                Console.WriteLine("Yeni Fiyat:");
                                double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                                urunler[i] = yeniUrun;
                                fiyatlar[i] = yeniFiyat;
                                Console.WriteLine("Ürün Güncellendi");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                    }
                    else if (secim == 3)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i}. {urunler[i]} - {fiyatlar[i]} TL");
                        }
                        Console.WriteLine("Silmek istediğiniz ürün numarası:");
                        int silinecekNo = Convert.ToInt32(Console.ReadLine());

                        if (silinecekNo >= 0 && silinecekNo < urunler.Length)
                        {
                            for (int i = silinecekNo; i < urunler.Length - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];
                                fiyatlar[i] = fiyatlar[i + 1];
                            }
                            Array.Resize(ref urunler, urunler.Length - 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                            Console.WriteLine("Ürün Silindi");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı işlem");
                            Thread.Sleep(2000);
                        }

                    }
                    else if (secim == 4)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i}. {urunler[i]} - {fiyatlar[i]} TL");
                        }
                        Thread.Sleep(4000);
                    }
                    else if (secim == 5)
                    {
                        Console.WriteLine("İyi günler");
                        admin = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim");
                    }
                }
            }
            #endregion

        }
    }
}
