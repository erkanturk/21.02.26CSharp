namespace _20_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Bir method tanımlayacağız indirim diye kullanıcıdan 2 ürün fiyatı girmesini isteyeceğiz
            //Girilen fiyatlardan ucuz olana %30 indirim uygulayacağız ve kullanıcıya 3. üründe %50
            //İndirim olduğunu söyleyeceğiz kullanıcıdan alınan cevaba göre 3.ürüne yönlendireceğiz
            //Ve 3. ürünün fiyatını isteyeceğiz sonrasında 1.2.3 fiyatın her birinin toplam tutarları ekrana yazdırılacak.
            //eğer kullanıcı 3. ürüne gitmek istemezse 1. ve 2. ürünün toplam tutarını ekrana yazdıracağız
            //Indirim();
            #endregion
            #region Ödev2
            //Rasgele 1-100 arasında değer oluşturan ve bu değerler
            //15 değer tutan bir diziye aktaralım ve bu dizideki
            //Dizideki tek ve çift sayısına göre  dizilerin uzunluğu belli olacak ve 
            //tek ve çift sayıları ayrı ayrı diziye atayan method yazılacak.
            //Ve ekrana yazdıralım.
            DiziDoldur();
            #endregion
        }
        #region Ödev 1
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı");
            double f1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı");
            double f2 = Convert.ToDouble(Console.ReadLine());
            if (f1 > f2)
            {
                f2 *= 0.70;
            }
            else
            {
                f1 *= 0.70;
            }
            Console.WriteLine("Üçüncü ürünü almak ister misin (E/H)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                Indirim2(f1, f2);
            }
            else if (cevap == "H")
            {
                Console.WriteLine($"Ödeme {f1 + f2}");
            }
        }
        static void Indirim2(double fiyat, double fiyat2)
        {
            Console.WriteLine("3.Ürün fiyatı");
            double fiyat3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme {fiyat + fiyat2 + (fiyat3 / 2)}");
        }
        #endregion
        #region Ödev2
        static void DiziDoldur()
        {
            int[] tekSayilar = new int[0];
            int[] ciftSayilar = new int[0];
            int[] sayilar = new int[15];
            Random r = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = r.Next(1, 100);
                sayilar[i] = sayi;
                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);//dizinin boyutu.
                    ciftSayilar[ciftSayilar.Length - 1] = sayi;//index değeri
                }
                else
                {
                    Array.Resize(ref tekSayilar, tekSayilar.Length + 1);//dizinin boyutu.
                    tekSayilar[tekSayilar.Length - 1] = sayi;//index değeri
                }
            }
            DiziYazdir("Random Sayılar",sayilar);
            DiziYazdir("Tek Sayılar",tekSayilar);
            DiziYazdir("Çift Sayılar",ciftSayilar);

        }
        static void DiziYazdir(string deger,int[] dizi)
        {
            Console.WriteLine("**********");
            foreach (int i in dizi)
            {
                Console.WriteLine($"{deger}=>{i}");
            }
        }
        #endregion
    }
}
