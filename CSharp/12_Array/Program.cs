namespace _12_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diziler(Array) string ifadeler aslında birer dizidir.Erkan =>içinde birden çok eleman taşır.
             * Dizilerde birden çok yapıyı içinde barındıran collection(koleksiyon) yapılarıdır.
             * Dizileri tanımlarken eleman sayısını belirtmemiz ve belitmediğimiz durumlar vardır.(Uzunluk mutlaka belli olmalıdır.)
             * Dizi elemanları çağırılırken yada  güncelleme durumunda index değerine göre işlem yapılır
             * !!! İndex değeri her zaman 0 dan başlar !!!
             * Dizi tanımlama yapısında bir veri tipi  belirtiriz ve uzunluk miktarı mutlaka olmalıdır.Olmama durumları (kullanıcıdan veya farklı
             * Bir dizi yapısından gelecektir.)
             * Dizi tanımı
             * veriTipi[] diziAdi=new veriTipi[uzunluk];//boş dizi tanımlama
             * veriTipi[] diziAdi={eleman1,eleman2,eleman3};//dolu dizi tanımlama
             * new keyword üretilen nesneyi temsil eder ve bellekte yer açar
            */


            #region Dizi yapısı 
            ////5 elemanlı 4 indexli bir dizi.
            ////index => 0,1,2,3,4
            ////Eleman=>1,2,3,4,5
            //string[] adlar = new string[5];//boş dizi
            //adlar[0] = "Erkan";
            //adlar[1] = "Efe";
            //adlar[2] = "Can";
            //adlar[3] = "Aziza";
            //adlar[4] = "Gökçe";
            //adlar[5] = "Ali";//Hata verir:Sysyem.IndexOutOfRangeException: index aşımı hatası.
            //Console.WriteLine(adlar[1]);
            ////Console.WriteLine(adlar);//bu şekilde bana değerleri getirmez.
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i] + " index değerleri=> " + i + " eleman değeri=>" + (i + 1));
            //}

            //string[] iller = { "Adana", "Amasya", "", "Sinop", "Sivas", "İstanbul", "İzmir", "Kocaeli", "Ankara" };
            //int index = 0;
            //while (iller.Length > index)
            //{
            //    Console.WriteLine(iller[index]);
            //    index++;
            //}
            //iller[0] = "Adıyaman";//Mevcut indexde bulunan değeri güncelle.
            //Console.WriteLine("*********************");
            //for (int i = 0; i < iller.Length; i++)
            //{
            //    Console.WriteLine(iller[i]);
            //}

            //int[] sayilar = new int[10];//10 elemanlı 9 indexli yapıda istediğimiz indexlere değer ekleme ve olmayan indexleri 0 olarak gösterme.
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[5] = 40;
            //sayilar[4] = 60;
            //sayilar[7] = 55;
            //sayilar[8] = 75;
            //sayilar[9] = 100;
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]);
            //Console.WriteLine(sayilar[4]);
            //Console.WriteLine(sayilar[5]);
            //Console.WriteLine(sayilar[6]);
            //Console.WriteLine(sayilar[7]);
            //Console.WriteLine(sayilar[8]);
            //Console.WriteLine(sayilar[9]);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region Personel
            //Kullanıcıya kaç adet personeli olduğunu soralım kullanıcıdan aldığımız sayı kadar personel adı soyadı girelim ve
            //Bu personellerin her birini ekrana yazdıralım.

            //Console.WriteLine("Kaç personeliniz var");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] adlar = new string[personelSayisi];
            //string[] soyadlar = new string[personelSayisi];

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Personel Adı");
            //    adlar[i] = Console.ReadLine();//Personelin [i]ninci yani 0. index'ine ekleme yapıyoruz.
            //    Console.WriteLine($"{i + 1}.Personel Soyadı");
            //    soyadlar[i] = Console.ReadLine();

            //}
            //Console.WriteLine("***************");
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine($"Personellerim Ad: {adlar[i]} Soyad: {soyadlar[i]}");
            //}

            #endregion

            #region Foreach
            //Foreach yapısı koleksiyon döngü yapısıdır.
            //char[] harfler = { 'A', 'B', 'C', 'D' };

            //foreach (char item in harfler)
            //{
            //    Console.WriteLine(item+" => "+(int)item);
            //}
            //object[] nesne = { "Erkan", 32, 'E', true, DateTime.Now, 32.5, 123.456m };//Her değeri taşıyan dizi
            //foreach (object abc in nesne)
            //{
            //    Console.WriteLine(abc);
            //}
            #endregion
            #region ArrayMethods Clear
            ////*****Clear*****
            //string[] adlar = { "Erkan", "Efe", "Can", "Aziza", "Gökçe" };
            ////foreach (string item in adlar)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Array.Clear(adlar);//Adlar dizisindeki tüm elemanları siler.
            ////Console.WriteLine("************");
            ////foreach (string item in adlar)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Array.Clear(adlar, 1, 2);//Adlar dizisinin 1. indexinden başlayarak 2 elemanı sil
            //foreach (string item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            //Uzunluğunu azaltmaz elemanları siler.
            #endregion
            #region Copy
            //string[] adlar = { "Erkan", "Efe", "Can", "Aziza", "Gökçe", "Yunus" };
            //string[] adlar2 = new string[adlar.Length];//dolu olan dizinin uzunluğu kadar eleman barındırabilir.

            //Array.Copy(adlar, adlar2, 4);//6 elemandan 4 elemanı sadece kopyala dedim ve bu elemanları yeni bir diziye kopyaladı.
            //Array.Copy(adlar, 1, adlar2, 1, 4);//Adlar dizisinden 1. indexden başla ve adlar2 dizisine 2. indexden intibaren 3 eleman kopyala
            //foreach (string item in adlar2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region IndexOf
            //string[] adlar = { "Erkan", "Efe", "Can", "Aziza", "Gökçe", "Yunus", "Efe", "Can", "Efe" };

            //int index = Array.IndexOf(adlar, "Efe");//İlk bulduğu değeri getirir.
            //Console.WriteLine(index);
            //Console.WriteLine(adlar[index]);

            //int index2 = Array.IndexOf(adlar, "Efe", 2);

            //Console.WriteLine(index2);
            //Console.WriteLine(adlar[index2]);
            //string[] degerler = new string[0];
            //int deger = 0;
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    if (adlar[i] == "Efe")
            //    {


            //        Console.WriteLine(adlar[i] + " index " + (i));
            //        Array.Resize(ref degerler, degerler.Length+1);
            //        degerler[deger] = adlar[i];
            //        deger++;
            //    }
            //}
            //Console.WriteLine("************");
            //foreach (string item in degerler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region LastIndexOf
            //string[] adlar = { "Erkan", "Efe", "Can", "Aziza", "Gökçe", "Yunus", "Efe", "Can", "Efe" };

            //int index = Array.LastIndexOf(adlar, "Efe");//Sondan İlk bulduğu değeri getirir.
            //Console.WriteLine(index);
            //Console.WriteLine(adlar[index]);
            //int index2 = Array.LastIndexOf(adlar, "Can", 6);//belirtilen indexden aramaya başla lastindexof yapısında
            //                                                //- ye doğru gider indexof ise + ya  doğru gider

            //Console.WriteLine(index2);
            //Console.WriteLine(adlar[index2]);
            #endregion
            #region Sort&&Reverse
            //string[] adlar = { "Erkan", "Efe", "Can", "Aziza", "Gökçe", "Yunus", "Efe", "Can", "Efe", "Ali" };
            //int[] sayilar = { 99, 50, 25, 10, 1, 975, 44, 63, 22, 33 };
            ////Array.Reverse(adlar);//Tersine çevir
            ////Array.Reverse(sayilar);//Tersine çevir
            //////Var olan yapıyı tersine çevirir.
            //Array.Sort(adlar);//A dan Z ye sıralar
            //Array.Sort(sayilar);//Küçükten büyüğe sıralar.
            //Array.Reverse(adlar);//Büyükten küçüğe sıralama
            //Array.Reverse(sayilar);
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine($"Adlar dizisi {adlar[i]}");
            //}
            //Console.WriteLine("**************");
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine($"Sayılar Dizisi {sayi}");
            //}
            #endregion
            #region Resize
            //int[] sayilar = new int[3];
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            ////sayilar[3] = 4;
            //Array.Resize(ref sayilar, 8);//Eleman sayısı olarak yeni boyut değerini veriyoruz
            //sayilar[3] = 44;
            //sayilar[4] = 45;
            //sayilar[5] = 46;
            //sayilar[6] = 47;
            //sayilar[7] = 55;
            ////Array.Resize(ref sayilar, sayilar.Length - 1);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.WriteLine("**************************");
            //Array.Resize(ref sayilar, sayilar.Length + 1);
            //Array.Resize(ref sayilar, sayilar.Length + 1);
            //Array.Resize(ref sayilar, sayilar.Length + 1);
            //Array.Resize(ref sayilar, sayilar.Length + 1);

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion
        }
    }
}
