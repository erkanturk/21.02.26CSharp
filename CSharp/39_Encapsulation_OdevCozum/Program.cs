namespace _39_Encapsulation_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev Kapsülleme
            /*** Ödev ***
        Bir banka hesabını temsil eden bir uygulama geliştirmek istiyoruz. 
        Bu uygulamada, kullanıcı kendi bakiyesini görebilecek fakat  başkaları görememeli
        bir kullanıcı girişi olsun atm sistemi gibi o yapıda kullanıcı şifresini girerse 
        1-para çek 2-para yatır 
       fakat kullanıcı eğer kendisi değilse sadece bu sisteme para gönderilsin.
        Kapsülleme (encapsulation) prensibini kullanarak bakiyeye 
        doğrudan erişimi engelleyeceğiz ve işlemler sırasında gerekli kontrolleri yapacağız.

       Kapsülleme (Encapsulation): Verileri dışarıya karşı korumak ve kontrollü 
                erişim sağlamak için kapsülleme prensibini kullanın.
       Veri Doğrulama: Metotlar içinde girilen tutarların geçerli olup olmadığını kontrol edin.
       Metot İsimlendirme: Metot isimlerinin anlamlı ve eylem odaklı 
        olmasına dikkat edin (örneğin, Deposit, Withdraw).
       */
            #endregion

            BankaAccount bankaAccount = new BankaAccount();
            while (true)
            {
                Console.WriteLine("Muhasebe birimine hoşgeldiniz.\nMuhasebe için 1 e basınız Çıkış için Q ya basınız");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Kullanıcı adınız:");
                    string kullaniciAdi = Console.ReadLine();
                    Console.WriteLine("Şifreniz:");
                    string sifre = Console.ReadLine();
                    if (kullaniciAdi == "admin" && sifre == "1234")
                    {
                        Console.WriteLine("Yatırılacak Tutar:");
                        double tutar = Convert.ToDouble(Console.ReadLine());
                        bankaAccount.ParaYatir(tutar);
                        Console.WriteLine($"Muhasebe tarafından {tutar} transfer edilmiştir");
                    }
                    continue;
                }
                else if (secim == "Q" || secim == "q")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                }
            }
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Banka hesabınıza hoşgeldiniz.\n1-Para Çek\n2-Para Yatır\n3-Bakiye Görüntüle\nÇıkış için Q ya basınız");
                string secim = Console.ReadLine();
                if (secim=="1")
                {
                    Console.WriteLine("Çekmek istediğiniz miktar");
                    double tutar = Convert.ToDouble(Console.ReadLine());
                    bankaAccount.ParaCek(tutar);
                    Console.WriteLine($"Güncel bakiye:{bankaAccount.BakiyeGoruntule()}");
                    Thread.Sleep(2000);
                }
                else if (secim=="2")
                {
                    Console.WriteLine("Yatırmak istediğiniz miktar");
                    double tutar = Convert.ToDouble(Console.ReadLine());
                    bankaAccount.ParaYatir(tutar);
                    Console.WriteLine($"Güncel bakiye:{bankaAccount.BakiyeGoruntule()}");
                    Thread.Sleep(2000);
                }
                else if (secim=="3")
                {
                    Console.WriteLine($"Güncel bakiye:{bankaAccount.BakiyeGoruntule()}");
                    Thread.Sleep(2000);
                }
                else if (secim == "Q" || secim == "q")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    Thread.Sleep(2000);
                    Console.ResetColor();
                    Console.Clear();
                    Console.WriteLine("İyi günler");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                }
            }
        }
    }
    class BankaAccount
    {
        private double Hesap = 20000;
        public double _Hesap
        {
            get
            {
                return Hesap;
            }
            set
            {
                if (value > 0)
                {
                    Hesap += value;
                }
                else
                {
                    Console.WriteLine("Hesap bakiyesi 0 veya negatif olamaz.");
                }

            }
        }
        public void ParaCek(double tutar)
        {
            if (tutar > 0 && tutar <= Hesap)
            {
                Hesap -= tutar;
                Console.WriteLine($"{tutar} tl çekim yapıldı");
            }
            else
            {
                if (tutar <= 0)
                {
                    Console.WriteLine("Geçersiz bakiye işlemi");

                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");
                }
            }

        }
        public void ParaYatir(double tutar)
        {
            if (tutar > 0)
            {
                Hesap += tutar;
                Console.WriteLine($"{tutar} tl yatırıldı");
            }
            else
            {
                Console.WriteLine("Geçersiz bakiye işlemi");
            }
        }
        public double BakiyeGoruntule()
        {
            return _Hesap;
        }
    }
}
