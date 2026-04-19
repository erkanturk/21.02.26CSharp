using Microsoft.VisualBasic;

namespace _18_Params_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Params
            /* Params method
             * Params anahtar  kelimesi ile bir methoda değişken sayıda aynı tipde değer geçilebilmesini sağlar.
             * Params parametresi methodun son parametresi olarak tanımlanır ve bir methodda sadece 1 tane tanımlanır
             * Params ile belirtilen parametre bir dizi olarak işlenir bu da method içinde bir 
             * dizi erişilebileceği ve üzerinde işlem yapılabileceği anlamına gelir
             */
            #endregion
            //Params olmadan method yapısı
            //Yaz(10,20,30);//sadece iki parametre tanımlandığı için iki değer bekliyor.

            //Yaz2(10);//2. parametre zorunlu değildir. değer verilmesede sorun olmaz.
            //Yaz2(20, 2, 1, 3, 1, 2, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 3, 2, 3, 4, 4, 4, 5, 5, 1, 2, 3, 2, 1, 3, 1, 1, 2, 4, 3, 4, 5, 3, 4, 5, 1, 2, 3, 1, 2, 3);
            //Yaz3("test", "test2", "test3", "test4");
            //string[] adlar = { "Metin", "Metin2", "Metin3" };
            //DiziAl(adlar);//dizi alan bir methoddur sadece 1 dizi alır params görevi görmez.
            //ParamsAl(adlar, adlar[0], adlar[1], adlar[2], "deneme", "test", "naber", "yakup");
            ////Params yapısı sınırsız sayıda değer göndermemizi sağlar
            //Deger(213.1235, "Test", 'A', DateTime.Now, true, false, 10, 10.12m, adlar[1]);

            //double deger = 123;
            //object deger2 = deger;//boxing

            //object nesne = 123;
            //double number = (double)nesne;//unboxing
            //Console.WriteLine(deger2);


            foreach (var item in KdvUygula(100,200,300,400,500,600,700,800))
            {
                Console.WriteLine(item);
            }

        }
        static void Yaz(int sayi, int sayi2)
        {
            Console.WriteLine(sayi + sayi2);
        }
        static void Yaz2(int sayi, params int[] sayi2)
        {
            Console.WriteLine(sayi);
            foreach (var item in sayi2)
            {
                Console.WriteLine(item);
            }
        }
        static void Yaz3(params string[] strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziAl(string[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void ParamsAl(string[] dizi, params string[] degerler)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
        }
        static void Deger(double sayi, params object[] objects)
        {
            Console.WriteLine(sayi);
            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }
        }
        static double[] KdvUygula(params double[] parametreler)
        {
            double kdv = 1.20;
            double[] kdvli = new double[parametreler.Length];

            for (int i = 0; i < kdvli.Length; i++)
            {
                kdvli[i] = parametreler[i] * kdv;
            }
            return kdvli;
        }
        static double[] KdvUygula2(params double[] parametreler)
        {
            double kdv = 1.20;

            for (int i = 0; i < parametreler.Length; i++)
            {
                double deger = parametreler[i];
                deger = deger * kdv;
                parametreler[i] = deger;
            }
            return parametreler;
        }
    }
}
