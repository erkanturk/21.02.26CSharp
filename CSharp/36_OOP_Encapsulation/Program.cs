namespace _36_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region OOP
            /* Object Oriented Programming (Nesne yönelimli programlama)
             * İlk yazılım sıralı satırlar olarak geliştiriliyordu
             * Sonrasında class yapısı üzerinden geliştirilmeye başlandı ama hala büyük çaplı projeler yazılamıyordu
             * 
             * C dili => OOP geliştirilmesi ile C++ dili ortaya çıktı
             * C++ gün geçtikçe popüleritesini kaybeden ama önceki yıllarda yazılmış projeler üzerinde hala geliştirilen 
             * Çok güçlü bir dildir. Makine programlama, siber güvenlik, otomobil beyni, vb işlerde kullanılır
             * İnternetin icadı ile birlikte Java ve C# dilleri ortaya çıkmıştır.
             * 
             * OOP 4 temel ilkesi vardır.
             * 1-Encapsulation - Kapsülleme
             * 2-Inheritance - Kalıtım (Miras alma)
             * 3-Polymorphism - Çok biçimcilik
             * 4-Abstraction - Soyutlama
             * 
             
             */
            /* Encapsulation 
             * Bir nesnenin propertylerinde doğruluk kontrolü yapılması gerektiğinde kullanılan bir oop yapısıdır.
             * Propertyler private olarak tanımlanır ve dışarıdan erişime kapalı olur doğrudan propertye değer gönderilemez
             * Aynı property'nin benze isimde public olarak bir tanımlaması yapılır ve kullanıcıdan bu property'e data (veri) 
             * girişi yapılması istenir
             * girilen data set keyword ile kontrol edilerek asıl propertye aktarılır
             * get kısmı ise property'nin içindeki değeri okumak ve getirmek için kullanılır.
             
             */
            #endregion

            Islem islem = new Islem();
            //Console.WriteLine("Sayı giriniz");
            //islem.Sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Sayı 2 yi giriniz");
            //islem._Sayi2 = Convert.ToDouble(Console.ReadLine());

            //islem.Sayi2=10; // erişilemez çünkü private olarak tanımlanmıştır

            Vatandas vatandas = new Vatandas();
            Console.WriteLine("Tc No:");
            vatandas._TcNo = Convert.ToInt64(Console.ReadLine());

        }
    }
    class Vatandas
    {
        internal string AdSoyad { get; set; }
        private long TcNo { get; set; }
        public long _TcNo
        {
            get
            {
                return TcNo;
            }
            set
            {
                if (value.ToString().Length == 11)
                {
                    TcNo = value;
                    Console.WriteLine(TcNo);
                }
                else if (value != 11)
                {
                    Console.WriteLine("TC Kimlik Numarası 11 haneli olmalıdır.");
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası sadece rakamlardan oluşmalıdır.");


                }
            }
        }
    }

    class Islem
    {
        public double Sayi { get; set; }
        private double Sayi2 { get; set; }
        public double _Sayi2
        {
            get
            {
                return Sayi2;
            }
            set
            {
                if (value > 0)
                {
                    Sayi2 = value;
                    Console.WriteLine($"Sonuç {Sayi / Sayi2}");
                }
                else
                {
                    Console.WriteLine("Sayı sıfır olamaz veya Negatif değer olamaz.");
                }
            }
        }

    }
}
