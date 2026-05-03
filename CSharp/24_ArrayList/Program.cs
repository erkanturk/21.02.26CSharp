

using System.Collections;

namespace _24_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ManavOtomasyonu
            /*
            HAL - Toptancı
           * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
           * 5 adet meyve listelenecek
           * Meyve seçildikten sonra "Kaç Kilo?"
           * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
           * 
           * 
            MANAV
           * "Meyve mi Sebze mi?" diye müşteriye soracağız.
           * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
           * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
           * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
           * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
           * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

           MÜŞTERİ
           * Alınan ürünleri ekrana yazdırınız.
            */
            #endregion
            /*Koleksiyon Yapıları 
             * Arraylere benzer olarak içerisinde birden fazla veriyi barındıran data yapılarıdır.
             * string[] int[] char[] gibi arrayler içerisinde sadece ilgili data tipini tutabilirken
             * Collections yapıları içerisinde daha spesifik ve karmaşık yapıları da beraberinde birden 
             * çok veri tipi tutabilirler.
             * Collections yapıları içerisinde ArrayList, List(Generic), Queue, Stack,SortedList, HashTable, 
             * Dictionary gibi birçok farklı yapı bulunmaktadır.
             * Collection yapıları System.Collections ve System.Collections.Generic isim alanları içerisinde bulunmaktadır.
             * ICollection, IEnumerable, IList, IDictionary yapıları 
             * Collection yapılarının temelini oluşturan arayüzlerdir.
             */
            /*ArrayList
             * Array yapıları gibi sabit bir uzunluğu yoktur her yapıyı içerisinde barındırabilirler
             * Type safe değildir (tip güvenliği yoktur) 
             * Her değeri object olarak tutar bu
             * nedenle boxing ve unboxing işlemi gerçekleşir bu da performans kaybına neden olur.
             * uzunluğu 2 üzeri n olarak gelir 
             */
            #region ArrayList örnekleri
            //ArrayList liste = new ArrayList();//Boş arraylist
            //liste.Add(1);
            //liste.Add("Merhaba");
            //liste.Add(3.14);
            //liste.Add(true);
            //liste.Add(false);
            //liste.Add('A');
            //liste.Add(DateTime.Now);
            //liste.Add(new int[] { 1, 2, 3 });//ArrayList içerisinde array(Dizi) de tutabiliriz
            //liste.Add("Test");
            //liste.Add("");
            //liste.Add(null);
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(liste[1]);//İndex kavramı ile kullanılır
            //indexler 0 dan başlar
            //Uzunluk için length değil count kullanılır
            //Console.WriteLine("listenin eleman sayısı:" + liste.Count);
            //Console.WriteLine("Kapasitesi:" + liste.Capacity);

            //ArrayList list = new ArrayList() { 1, "Merhaba", 3.14, true, false, 'A', DateTime.Now, "Test", "", null };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion
            #region ArrayList Metodları
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("Merhaba");
            //list.Add(3.14);
            //list.Add(true);
            //list.Add(false);
            //list.Add('A');
            //list.Add(DateTime.Now);
            //list.Add("Test");

            ////ArrayDondur(list);
            //Console.WriteLine(list.Contains(1) ? "Var" : "Yok");
            ////Kontrol yöntemi
            ////Contains metodu aradığımız değerin listede olup olmadığını kontrol eder true false döner
            ////? operatörü if : else yapısının kısa hali olarak kullanılır

            ////Silme yöntemleri
            ////list.Clear();//Tüm elemanları siler
            ////ArrayDondur(list);
            ////list.Remove(false);//Belirtilen değeri siler
            ////list.RemoveAt(0);//Belirtilen indexteki değeri siler
            ////list.RemoveRange(0, 2);//Belirtilen indexten başlayarak belirtilen sayıda elemanı siler

            ////Ekleme yöntemleri
            //list.Add(1123);//Tekli ekleme yöntemi
            //list.AddRange(new ArrayList { "deneme", "153", "ArrayList", 'D', 123 });
            //// ArrayDondur(list);

            ////Ekleme yöntemleri
            //list.Insert(0, "Başlangıç");//Belirtilen indexe tekli ekleme yöntemi
            //list.InsertRange(3, new ArrayList { "test2", "22", 33, 44 });
            ////ArrayDondur(list);

            //list.Reverse();//listeyi ters çevirir
            //               // ArrayDondur(list);
            //               //list.Sort();//Sıralama yapar ancak içerisinde farklı türler olduğu için hata verir
            //               // ArrayDondur(list);
            //ArrayList sayilar = new ArrayList() { 5, 3, 8, 1, 4 };
            //// sayilar.Sort();//Tek tip veri içerdiği için sıralama yapabilir
            //ArrayDondur(sayilar);
            //Console.WriteLine("***************");
            //Console.WriteLine(sayilar.IndexOf(8));//Belirtilen değerin indexini döner
            //Console.WriteLine(sayilar.LastIndexOf(8));//Belirtilen değerin son indexini döner

            //object[] nesne = list.ToArray();//ArrayList'i arraye formatına dönüştürür
            //Console.WriteLine(nesne[5]);
            //int[] sayilar2 = sayilar.ToArray(typeof(int)) as int[];//ArrayList'i belirtilen türde arraye dönüştürür
            ////as operatörü belirtilen türde dönüştürme yapar eğer dönüşüm başarısız olursa null döner
            //Console.WriteLine(sayilar2[2]);

            #endregion
            #region ArrayList Örnek Uygulama
            //ArrayList liste = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("listeye eklemek istediğiniz değer");
            //    string deger = Console.ReadLine();
            //    if (int.TryParse(deger, out int sayi))
            //    {
            //        liste.Add(sayi);
            //    }
            //    else
            //    {
            //        liste.Add(deger);
            //    }
            //    Console.WriteLine("Eklenen");
            //    foreach (var item in liste)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            //    string devam = Console.ReadLine().ToUpper();
            //    if (devam == "E")
            //    {
            //        continue;
            //    }
            //    else if (devam == "H")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı tuşlama ");
            //        Thread.Sleep(10000);

            //    }

            //}
            //Console.WriteLine("Dolu liste");
            //ArrayDondur(liste);
            #endregion

            //ArrayList liste = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("listeye eklemek istediğiniz değer");
            //    string deger = Console.ReadLine();
            //    if (int.TryParse(deger, out int sayi))
            //    {
            //        liste.Add(sayi);
            //    }
            //    else
            //    {
            //        liste.Add(deger);
            //    }
            //    Console.WriteLine("Eklenen");
            //    foreach (var item in liste)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            //    string devam = Console.ReadLine().ToUpper();
            //    if (devam == "E")
            //    {
            //        continue;
            //    }
            //    else if (devam == "H")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı tuşlama ");
            //        Thread.Sleep(10000);

            //    }

            //}
            //Console.WriteLine("Dolu liste");
            //ArrayDondur(liste);


        }
        static void ArrayDondur(ArrayList liste)
        {
            Console.WriteLine("**********");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
