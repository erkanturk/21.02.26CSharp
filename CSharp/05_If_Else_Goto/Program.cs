namespace _05_If_Else_Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {   //https://www.w3schools.com/cs/index.php
            #region Ödev
            //Kullanıcıdan 3 adet sayı alınız ve bu sayıları A şeklinde görüldüğü gibi büyükten küçüğe sıralayınız 
            //ve ekrana yazdırınız
            //A Şekli: 15>13>5 Console.WriteLine(15) Console.WriteLine(13) Console.WriteLine(5)

            //2. ödev
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; Hava sıcaK uyarısı versin. 
            //3.Ödev

            //kullanıcıdan isim , yaş, maaş ve çocuk sayısı istenecek 
            //eğer kullanıcı 45 yaşının altında ise çocuk sayısına bakılacak
            //ve çocuk sayısı 3'ten az ise çocuk başına 2500₺ 3'ten fazla ise çocuk başına 2000₺ maaş eklemesi yapılacak
            //45 in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak
            //Son olarak ekrana :Erkan Türk Maaşınız 40000₺ yazılacak.
            #endregion
            #region Goto
            Console.WriteLine("Çay demleme  algoritması");
            Thread.Sleep(5000);//Thread.Sleep() belirtilen sürede delay ekler yani bekletir ekranı içerisindeki değer milisaniye
        mutfak:
            Console.WriteLine("Mutfağa git");
            Thread.Sleep(2000);
            Console.WriteLine("Çay Su Var Mı ? (E/H)");
            Thread.Sleep(2000);
            string cevap = Console.ReadLine().ToUpper();//ToUpper girilen her karakteri büyültür.
            if (cevap == "E")
            {
                Console.WriteLine("Çaydanlığa su koy");
                Thread.Sleep(2000);
                Console.WriteLine("Ocağın altını yak");
                Thread.Sleep(2000);
                Console.WriteLine("Çaydanlığı Ocağa Koy");
                Thread.Sleep(2000);
            demleme:
                Console.WriteLine("Çay Demlendi mi ? (E/H)");
                string deger = Console.ReadLine();
                if (deger == "E")
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Demliğe su koy");
                }
                else if (deger == "H")
                {
                    Console.WriteLine("Bekle");
                    goto demleme;
                }

            }
            else if (cevap == "H")
            {
                Console.WriteLine("Bakkala git");
                Thread.Sleep(2000);
            bakkal:
                Console.WriteLine("Bakkal Açık mı ?(E/H)");
                string cevap2 = Console.ReadLine();
                if (cevap2 == "E")
                {
                    Console.WriteLine("Eksikleri Al");
                    Thread.Sleep(2000);
                    Console.WriteLine("Eve Dön");
                    Thread.Sleep(2000);
                    goto mutfak;
                }
                else
                {
                    Console.WriteLine("Başka bakkala git");
                    goto bakkal;
                }
            }
            #endregion
            #region Random 
            //Random random = new Random();
            //int rasgele = random.Next(1, 50);//50 dahil olmaz
            //Console.WriteLine(rasgele);

            Random random = new Random();
            int sanliSayi = random.Next(1, 50);
            int hak = 3;
        basla:
            Console.WriteLine("Lütfen Şanslı Sayıyı Giriniz");
            int kullaniciSayi = Convert.ToInt32(Console.ReadLine());
            if (sanliSayi == kullaniciSayi)
            {
                Console.WriteLine("Tebrikler doğru tahmin");
            }
            else if (hak != 0)
            {
                hak--;
                Console.WriteLine("Tekrar deneyin");
                if (hak == 0)
                {
                    Console.WriteLine("Şanslı sayı: " + sanliSayi);
                }
                else
                {
                    goto basla;
                }

            }


            #endregion
            #region örnek
            //300 den başlayarak 7 ye tam bölünenleri ekrana yazdıran goto yapısı
            //int sayi = 300;
            //don:
            //if (sayi % 7 == 0)
            //{
            //    Console.WriteLine(sayi);
            //    sayi--;
            //    goto don;
            //}
            //else
            //{

            //    sayi--;
            //    if (sayi != 0)
            //    {
            //        goto don;
            //    }
            //    else
            //    {
            //        Console.WriteLine("işlem tamamlandı");
            //    }
            //}

            #endregion
            #region Soru
            //Kullanıcıdan değer alacağız kullanıcının girdiği değer pozitif sayı değerini göstereceğiz
            //Eğer kullanıcı 0 girerse tekrardan kullanıcıya bir sayı girmesi adımına yönlendireceğiz
            //kullanıcı negatif yada pozitif değer girdiğinde
            //ekrana girilen değer yazılacak fakat 0 değeri girerse her seferinde başlangıca yönlenecek
            //basla:
            //    Console.WriteLine("Bir değer giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    if (sayi2 == 0)
            //    {
            //        goto basla;
            //    }
            //    else if (sayi2 > 0)
            //    {
            //        Console.WriteLine("Girilen sayı pozitiftir: " + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girilen sayı negatiftir: "+sayi2);
            //    }
            #endregion

            #region Soru 2
            //Kullanıcıdan bir sayı alacağız kullanıcıdan aldığımız sayı eğer sıfırsa tekrar sayı girmesini isteyeceğiz.
            //Eğer kullanıcının girdiği sayı 10 sa tekrar sayı girecek 20 girdi sonrasında 30 olarak artarak bu sayılar toplanacak
            //Kullanıcı ilk değer dışında 0 a basarsa ekrana toplam girdiği sayıların toplamını yazacak ve işlem sonlanacak 
            int sayac = 0;
            int toplam = 0;

        git:
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0 && sayac == 0)
            {
                Console.WriteLine("İlk değer 0 girilemez");
                goto git;
            }
            if (sayi == 0)
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            else if (sayi > 0)
            {
                sayac++;
                toplam += sayi;
                goto git;
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Lütfen Pozitif sayı giriniz");
                goto git;
            }
            Console.WriteLine("Toplam: "+toplam);
            #endregion
            
        }
    }
}
