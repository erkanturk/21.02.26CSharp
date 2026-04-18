namespace _16_OverLoad_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aşırı yüklemeli method 
             * Normal durumlarda methodlar aynı isim değerlerini taşıyamazlar
             * Fakat overload method yapısı ile aynı isimdeki method 
             * Farklı imza tipi ile tanımlanabilinir
             * Bu yapıya eş değer olarak sık kullandığımız hazır methodlar da vardır
             * Console.WriteLine() methodu aşırı yüklemeli bir method yapısıdır
             * Kendisi ile birlikte toplam 19 farklı yapısı tek isim ile kullanılır.
             * OOP temel ilkelerinden biri olan Polymorphism yapısını destekleyen static polymorphism yapısına
             * overload method yapısı denir.
             * Bir methodun birden fazla tip ile bize cevap verebilmesini sağlar.
             */
            /*Summary yapısı
             * Developer'ların methodların ne işlem yaptığını belirtmek yada kullanan kişinin bu methodun 
             * Nasıl veya ne için yapıldığı konusunda bilgi vermek için kullanılan yapıdır. 
             
             */
            //Console.WriteLine("Merhaba");
            //Console.WriteLine(10);
            #region işlem 1
            //Yaz("deneme", 10);
            //Yaz(10.55, 10);
            //Yaz(10, 22.5);
            //Yaz();
            //Yaz("test");
            //Yaz(10);
            #endregion
            #region Overload method yapısı
            Islem(10, 20);//Toplama
            Islem(20.0, 10);//Çıkartma
            Islem(22, 33.0);//Çarpma
            Islem(150.0, 2.0);//Bölme
            Islem();
            #endregion

        }
        #region İşlem1
        //static void Yaz()
        //{
        //    Console.WriteLine("Merhaba");
        //}
        //static void Yaz(string metin)
        //{
        //    Console.WriteLine(metin);
        //}
        //static void Yaz(int sayi)
        //{
        //    Console.WriteLine(sayi);
        //}
        //static void Yaz(string metin, int sayi)
        //{
        //    Console.WriteLine(metin+","+sayi);
        //}
        //static void Yaz(int sayi, double sayi2)//Parametrelerin sırası ve tipi önemlidir.
        //{
        //    Console.WriteLine(sayi + sayi2);
        //}
        //static void Yaz(double sayi, int sayi2)
        //{
        //    Console.WriteLine(sayi + sayi2);
        //}
        #endregion
        #region Matematiksel işlemler
        /// <summary>
        /// İki tam sayı alan ve bu aldığı değerleri toplayan method yapısı
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Islem(int sayi, int sayi2)
        {
            Console.WriteLine("Toplama işlemi sonucu:" + (sayi + sayi2));
        }
        /// <summary>
        /// ilk değeri ondalıklı ikinci değeri tam sayı 
        /// bu method yapısı çıkartma işlemi yapar.
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Islem(double sayi, int sayi2)
        {
            Console.WriteLine("Çıkartma işlemi sonucu:" + (sayi - sayi2));
        }
        /// <summary>
        /// ilk değeri tam sayı ikinci değeri ondalıklı
        /// bu method yapısı çarpma işlemi yapar.
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Islem(int sayi, double sayi2)
        {
            Console.WriteLine("Çarpma işlemi sonucu:" + (sayi * sayi2));
        }
        /// <summary>
        /// İki ondalıklı sayı alan bu method yapısı bölme işlemi yapar.
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        static void Islem(double sayi, double sayi2)
        {
            if (sayi2 != 0)
            {
                Console.WriteLine(sayi / sayi2);
            }
            else
            {
                Console.WriteLine("hata");
            }
        }
        /// <summary>
        /// Bu method yapısı faktoriyel hesaplayan bir method
        /// <see href="https://tr.wikipedia.org/wiki/Fakt%C3%B6riyel"/>
        /// </summary>
        static void Islem()
        {
            Console.WriteLine("Faktöriyel hesaplama için sayı giriniz");
            long sayi = Convert.ToInt64(Console.ReadLine());//Convert.ToInt64 Long sayısında kullanılır.
            //int yapısında hata verir.
            long faktoriyel = 1;
            for (long i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine($"Faktoriyel {faktoriyel}");
        }
        #endregion
    }
}
