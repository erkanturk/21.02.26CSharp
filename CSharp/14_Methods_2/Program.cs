namespace _14_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek
            //Kullanıcıdan iki sayı alalım bu sayıları toplayan methodu yazalım
            //int a=10;
            //int b=20;
            //Topla(a,b);
            //Topla(15, 25);
            //Kullanıcıdan iki ürün fiyatı isteyelim aldığımız ürün fiyatlarından ucuz olana %30 indrim yapalım 

            //Console.WriteLine("1.Ürün fiyatı");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün fiyatı");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());

            //Indirim(fiyat, fiyat2);
            //IndirimYap();
            #endregion
            /* 4 işlem methodu  
             * 4 adet methodumuz olacak 
             * bu methodlar iki adet parametre alacak sayısal tipte
             * gelen değerler toplama çıkarma çarpma bölme işlemine tabi tutulacak 
             * 
            
            */
            #region Örnek 2 
            //Console.WriteLine("1.Sayı");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlem\n(+)\n(-)\n(*)\n(/)\n(%)");
            //char islem = Convert.ToChar(Console.ReadLine());

            //if (islem == '+')
            //{
            //    Topla(sayi,sayi2);
            //}
            //else if (islem == '/')
            //{
            //    Bol(sayi, sayi2);
            //}
            //else if (islem == '*')
            //{
            //    Carp(sayi, sayi2);
            //}
            //else if (islem == '-')
            //{
            //    Cikart(sayi, sayi2);
            //}
            //else if (islem == '%')
            //{
            //    Mod(sayi, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı seçim");
            //}
            #endregion
            #region Örnek3
            //Bir dizi olacak bu dizide ürün fiyatlarımız olacak
            //bu ürün fiyatlarına kdv uygulayacağız ve kdvli fiyatı ekrana yazdıracağız
            //string[] urunler = { "Elma", "Armut", "Ananas", "Kivi", "Karpuz" };
            //double[] fiyatlar = { 150, 250, 350, 450, 550 };

            //KdvUygula(fiyatlar,urunler);
            #endregion

            #region Otomat Method
            OtomatMakinesi();
            #endregion
        }
        #region Örnek yapısının methodları
        static void Indirim(double f1, double f2)//parametrelide dışarıdan gelen değerler methoda aktarılır.
        {
            if (f1 > f2)
            {

                Console.WriteLine(f2 *= 0.7);
            }
            else
            {
                Console.WriteLine(f1 *= 0.7);
            }
        }
        static void IndirimYap()//parametresizde değerler method içerisinde alınır.
        {
            Console.WriteLine("1.Ürün fiyatı");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün fiyatı");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat > fiyat2)
            {

                Console.WriteLine(fiyat2 *= 0.7);
            }
            else
            {
                Console.WriteLine(fiyat *= 0.7);
            }

        }
        static void Topla(int sayi, int sayi2)
        {
            Console.WriteLine(sayi + sayi2);
        }
        #endregion
        #region Örnek 2 methodları
        static void Topla(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        static void Bol(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Sayı sıfıra bölünemez");
            }
            else
            {
                Console.WriteLine(x / y);
            }

        }
        static void Carp(double deger, double deger2)
        {
            Console.WriteLine(deger*deger2);
        }
        static void Cikart(double s1, double s2)
        {
            Console.WriteLine(s1 - s2);
        }
        static void Mod(double m1, double m2)
        {
            Console.WriteLine(m1 % m2);
        }
        #endregion
        static void KdvUygula(double[] dizi, string[] dizi2)
        {
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = dizi[i] * 1.20;
            //}
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine($"Kdv uygulanmış ürün fiyatları: {dizi[i]} Ürünler: {dizi2[i]}");
            //}
        }
        static void OtomatMakinesi()
        {
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
                                    AdminPanel(urunler,fiyatlar,admin);
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
        }
        static void AdminPanel(string[] urunler, double[] fiyatlar,bool admin)
        {
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
                        OtomatMakinesi();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim");
                    }
                }
            }
        }

    }
}
