namespace _14_Method_DegerDonduren_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Geriye değer döndüren methodlar
             * Void keyword'ü kullanılmaz int double decimal vb veri tipi yada sınıf
             * yapısı collection yapısı dizi yapısı vb yapılar döndürürler.
             * return ifadesi bulunmalıdır.
             * return ifadesi ile bir işlem sonucu yada bir değeri döndürebiliriz.
             * Birden fazla değer geriye dönderilmez.

             */
            #region Örnek 1
            //Console.WriteLine(Dondur());
            //Yaz();
            //double sayi = Dondur();
            //sayi *= 3;
            //Console.WriteLine(sayi);
            #endregion
            #region örnek2
            string deger = "Nasılsın";
            Yazdir(deger);
            
            Console.WriteLine(Yazdir2(deger));
            #endregion
        }
        static double Dondur()
        {
            return 123.45;
        }
        static void Yaz()
        {
            Console.WriteLine(123.45);
        }
        static void Yazdir(string metin)
        {
            Console.WriteLine(metin);

        }
        static string Yazdir2(string metin)
        {
            metin = "iyi sen.";
            return metin;
        }
    }
}
