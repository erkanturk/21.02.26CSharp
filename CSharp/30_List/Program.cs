namespace _30_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List Generic typelar verdiğimiz bize birden fazla veri tutabilen bir yapıdır.
             * List Generic tipler System.Collections.Generic isim alanında bulunur.
             * List Generic tipler ArrayList gibi referans tiplerdir. 
             * List Generic tipler dinamik olarak büyüyebilirler. 
             * List Generic tipler sıralı bir şekilde veri tutarlar. 
             * List Generic tipler indekslenebilirler. 
             * List Generic tipler aynı türdeki verileri tutmak için kullanılırlar. 
             * List Generic tipler performans açısından ArrayList'e göre daha iyidirler.
             * List Generic tipler LINQ sorguları ile kullanılabilirler. 
             * List Generic tipler foreach döngüsü ile kolayca gezilebilirler.
             * içerisinde barındırılan tipler int string bool datetime class vb olabilir.
             * Type safe bir yapıya sahiptir.
             * Fifo (First In First Out) yapısına sahiptirler.
             * <> generic tip belirtmek için kullanılır. List<string> gibi.
             */
            #region Boş liste tanımı
            //List<string> list= new List<string>();
            //list.Add("Ahmet");
            //list.Add("Mehmet");
            //list.Add("Ayşe");
            //list.Add("Fatma");
            //list.Add("Ali");
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////AddRange metodu ile birden fazla veri ekleyebiliriz.
            //list.AddRange(new List<string> { "Zeynep", "Emre", "Veli", "Cem" });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> yaslar= new List<int>() { 37,25, 30, 35,25, 40,40,40,40,40,45,18,27,17,15,13,16,19 };
            //foreach (var item in yaslar)
            //{
            //    if (item > 17)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //LINQ ileri seviye sorgulama dilidir. Veriler üzerinde sorgulama yapmamızı sağlar.
            //Lamda expression ile yazalım kısa fonksiyon tanımlama yöntemi
            //Linq Sorgusu Where yapısı koşul olarak filtreleme yapmamızı sağlar
            //Bil linq sorgu yapısıdır
            //ForEach metodu ile de tek tek yazdırabiliriz foreach döngüsü gibi çalışır fakat linq sorgusu ile birlikte kullanılır
            //Yaşlar listesine git
            //x yaşların içindeki elemanları temsil eder
            //x > 17 koşulunu sağlayanları filtrele
            //Filtrelenen elemanları listeye dönüştür
            //Dönüştürülen listeyi tek tek yazdır
            //ToList metodu ile IEnumerable tipindeki verileri List tipine dönüştürebiliriz.
            yaslar.Where(x => x > 17).ToList().ForEach(x => Console.WriteLine(x));
            int bul = yaslar.Find(x => x == 25);
            int bul2 = yaslar.FindIndex(y => y == 25);
            Console.WriteLine("*********");
            Console.WriteLine(bul);
            Console.WriteLine(bul2);
            int toplam = yaslar.Sum();//Sum metodu ile listedeki elemanların toplamını alabiliriz
            Console.WriteLine(toplam);
            Console.WriteLine("**********");
            int ortalama = (int)yaslar.Average();//Average metodu ile listedeki elemanların ortalamasını alabiliriz. Ortalama double döner bu yüzden int'e çevirdik.
            Console.WriteLine(ortalama);
            int sayi = 40;
            Console.WriteLine("************");
            Console.WriteLine(yaslar.FirstOrDefault()); //FirstOrDefault metodu ile listedeki ilk elemanı döndürür.
                                                        //Eğer koşula uyan eleman yoksa default değeri döner.
            int deger = yaslar.FirstOrDefault(d => d == sayi); //FirstOrDefault metodu ile koşula uyan ilk elemanı döndürür.
                                                               //Eğer koşula uyan eleman yoksa default değeri döner.
            Console.WriteLine(deger);
            Console.WriteLine("***********");
            int[] degerler = yaslar.Where(x => x == 40).ToArray();
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");

            foreach (var item in yaslar.Where(x => x == 40).ToList())
            {
                Console.WriteLine(item);
            }

            //AsQuaryble metodu ile listeyi sorgulanabilir hale getiririz. Böylece linq sorguları ile birlikte kullanabiliriz.
            yaslar.AsQueryable().Where(x => x > 10).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("********************");
            yaslar.Distinct().ToList().ForEach(x => Console.WriteLine(x));
            //Distinct metodu ile listedeki tekrar eden elemanları tekilleştirebiliriz.
            Console.WriteLine("***********");
            //OrderBy küçükte büyüğe sıralama yapar A Dan Z ye 1 den 100 e gibi
            //Ascending sıralama yapar küçükten büyüğe
            //Descending sıralama yapar büyükten küçüğe
            yaslar.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("*********");
            yaslar.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("*************");
            yaslar.Distinct().OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            //Select metodu ile listedeki elemanları istediğimiz şekilde dönüştürebiliriz. Örneğin yaşları 2 ile çarparak yeni bir liste oluşturabiliriz.
            Console.WriteLine("***********");
            yaslar.Select(x => x * 2).ToList().ForEach(x => Console.WriteLine(x));

            #endregion
        }
    }
}
