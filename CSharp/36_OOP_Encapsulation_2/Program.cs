namespace _36_OOP_Encapsulation_2
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
            //Araba araba = new Araba();
            ////araba._Hiz = 100;
            ////araba._Hiz = 200;
            ////araba._Hiz = 222;
            ////araba._Hiz = 300;
            ////araba._Hiz = -200;
            ////Console.WriteLine(araba._Hiz);
            //araba.Hizlan(50);
            //araba.Hizlan(50);
            //araba.Hizlan(50);
            //araba.Hizlan(50);
            //araba.Hizlan(50);
            //araba.Hizlan(50);
            //araba.Hizlan(50);
            //araba.Yavasla(50);
            //araba.Yavasla(50);
            //araba.Yavasla(50);
            //araba.Yavasla(50);
            //araba.Yavasla(50);
            //araba.Yavasla(50);

            Kisi kisi = new Kisi();
            kisi._Ad = "Veli";
            kisi._Ad = "    ";
            kisi._Ad = null;
            kisi._Ad = "Ali";
            kisi._Yas =0;
            kisi._Yas =-10;
            kisi._Yas = 17;
            kisi._Yas = 18;
        }
    }
    class Kisi
    {
        private string Ad { get; set; }
        private int Yas { get; set; }

        public string _Ad
        {
            get
            {
                return Ad;
            }
            set
            {
              
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Ad boşluklarla doldurulamaz");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ad boş veya null olamaz");
                }
                else if (value.StartsWith("A"))
                {
                    Ad = value;
                    Console.WriteLine(Ad);
                }
                else
                {
                    Console.WriteLine("Ad 'A' harfi ile başlamalıdır");
                }

            }
        }
        public int _Yas
        {
            get
            {
                return Yas;
            }
            set
            {
                if (value<18)
                {
                    Console.WriteLine("Yaş 18 veya daha büyük olmalıdır");
                }
                else if (value < 0)
                {
                    Console.WriteLine("negatif değer girilemez");
                }
                else if(value>120)
                {
                    Console.WriteLine("Yaş 120'den büyük olamaz");
                }
                else
                {
                    Yas = value;
                    Console.WriteLine(Yas);
                }
            }
        }
    }
}
