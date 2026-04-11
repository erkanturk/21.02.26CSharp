namespace _14_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Methods-Function 
             * Methodlar  yazılımcılar tarafından geliştirilen ve diğeğr yazılımcıların kullanımına sunulan hazır kod yapılarıdır.
             * Metoda bir isim verilir ve o isim altında bir iş yapan kod bloğu yazılır ve yazılımcı o işi yapmak için methodu çağırması yeterlidir.
             * Bu sayede yazılımcı tanımlı işin kodunu tekrar tekrar yazmak yerine method yapısını çağırarak kullanır.
             * 
             * Methodlar ve fonksiyonlar () ile tanımlanır
             * Method içerisinde method yazılamaz. ama Method içerisinde başka bir method çağırabiliriz. 
             * Methodlar çağırılmadığı sürecede çalışmazlar.
             * Method isimleri benzersiz(Unique) olmalıdır.Aynı isme sahip method yapılarının 
             * imza yapısı ve parametre sayısı farklı olmalıdır.
             * Hazır method yapıları ile fonksiyonlar arasında fark vardır
             * Methodlar hazır yapılardır Fonksiyonlar ise yazılımcının yazdığı method yapılarıdır.
             * Methodlar 2 ye ayrılır.
             * Geriye değer döndüren(Parametreli/Parametresiz)
             * İş yapan(Parametreli/Parametresiz)
             * MyMethod();!!!Çağırma işlemi
             * Methodlar Genellikle PascalCase olarak Tanımlanır.
             */

            //Method Çağırma
            Yaz();
            IsimYaz("Erkan Türk");
            string deger = "Yakup";
            IsimYaz(deger);
            //IsimYaz(deger);//Method kaç defa çağrılırsa o kadar kendini tekrar eder.
            //IsimYaz(deger);
            //IsimYaz(deger);
            //IsimYaz(deger);
            //IsimYaz(deger);
            //IsimYaz(deger);
            //IsimYaz(deger);
            //IsimYaz(deger);
            //Console.WriteLine("Ad");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaş");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaş");
            //double maas = Convert.ToDouble(Console.ReadLine());
            //Kaydet(yas,ad,soyad,maas);
            Kaydey2();
        }
        //Method Tanımlama
        static void Yaz()//Void keyword'ünü gördüğümüz her yapı iş yapan methoddur.
        {
            Console.WriteLine("İş yapan Parametresiz method");
        }
        static void IsimYaz(string metin)//string metin değeri parametredir.
        {
            Console.WriteLine(metin);
        }
        static void Kaydet(int yas, string ad, string soyad, double maas)
        {
            Console.WriteLine($"Ad:{ad} Soyad:{soyad} Yaş:{yas} Maaş: {maas}");
        }
        static void Kaydey2()
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş");
            double maas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ad:{ad} Soyad:{soyad} Yaş:{yas} Maaş: {maas}");
        }
    }
}
