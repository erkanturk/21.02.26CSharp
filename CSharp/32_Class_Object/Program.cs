namespace _32_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erişim belirleyiciler
            /* Data Access Modifiers (Erişim Belirleyiciler)
             * Private: Sadece tanımlandığı sınıf içinde erişilebilir. Diğer sınıflardan erişilemez.
             *      Sınıf yapıları private olarak tanımlanamazlar. Ancak sınıf içindeki üyeler private olabilirler.
             * Public: Her yerden erişilebilir. Sınıf yapıları public olarak tanımlanabilirler. 
             *      Sınıf içindeki üyeler de public olabilirler.
             * internal: Aynı proje içindeki diğer sınıflardan erişilebilir. Farklı projelerden erişilemez.
             *       Sınıf yapıları internal olarak tanımlanabilirler. 
             *       Sınıf içindeki üyeler de internal olabilirler.
             * Protected:Sadece kalıtım (inheritance) yapısında erişilebilir. 
             *           Yani bir sınıfın protected üyesine sadece o sınıftan türetilen sınıflar erişebilirler.
             * Sealed: Bir sınıfın sealed olarak tanımlanması,
             *        o sınıfın başka sınıflar tarafından kalıtım yoluyla türetilemeyeceği anlamına gelir.
             *        Mühürlü sınıf yapısı olarak kullanılır.
             */
            #endregion

            Ogrenci ogrenci = new Ogrenci();
            //Öğrenci sınıfı private property taşıdığı için erişilemezler. Hata verirler.
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.OgretmenAd = "Erkan";
            ogretmen.OgretmenSoyad = "Türk";
            ogretmen.OgretmenNo = 123456;
            //ogretmen.Bolum = "Matematik";
            // ogretmen.Tel= 1234567890;
            ogretmen.OgretmenBilgileri();
            Console.WriteLine("***********");
            ogretmen.OgretmenAd = "Tahsin";
            ogretmen.OgretmenSoyad = "Canpolat";
            ogretmen.OgretmenNo = 654321;
            ogretmen.OgretmenBilgileri();

            Ogretmen ogretmen1 = new Ogretmen()
            {
                OgretmenAd="Altan",
                OgretmenSoyad="Demirci",
                OgretmenNo=789456,
                Bolum= "Fizik"
            };
            ogretmen1.OgretmenBilgileri();
            ogretmen1.OgretmenAd = "Onur";
            ogretmen1.OgretmenSoyad = "Yağız";
            ogretmen1.OgretmenNo = 7894563;
            ogretmen1.OgretmenBilgileri();
            //ogretmen1.Bolum = "Kimya";// Hata verir. Çünkü Bolum property init olarak tanımlanmıştır.
            // Sadece nesne oluşturulurken değer atanabilir.
        }
    }
}
