namespace _19_Out_Ref_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ref var olan bir değeri method içerisine gönderip bu değeri güncelleyip dışarı çıkarmak için kullanılan yöntemdir
             * Ref ile referans gösterdiğimiz bir değer olmalıdır bu değeri güncelleyip dışarı çıkarmamıza olanak tanır.
             * Örneğin Bir fabrika düşünün bu fabrikaya plastik bir malzeme geldi referansımız plastik
             * Bu malzeme sonrasında işlem gördü ve dışarıya oyuncak olarak çıktı makineden ve satışa hazır halde mağzalara sunuldu
             * ister koleksiyon olarak sunulabilir artık bu oyuncaklar ister satılabilir.
             
             */
            /*Out null olan bir değere işlem yapmamızı sağlar örneğin
             * Okuldan yeni mezun olduk hiç tecrübemiz yok 
             * Bir işe girdik sonra tecrübe edindik artık farklı bir işe geçiş yaparken eski çalıştığımız 
             * iş yerindeki tecrübeleri kullanacağız.
             */
            #region Ref örnekleri
            //int s = 1;
            //int s2 = 2;
            //int s3 = 3;
            //Console.WriteLine(s);//1
            //Console.WriteLine(s2);//2
            //Console.WriteLine(s3);

            //RefMethod(ref s, ref s2, s3);//Ref ve out birden fazla değeri dışarı çıkarır return ifadesi sadece 1 değeri çıkarır.
            //Console.WriteLine(s);//20
            //Console.WriteLine(s2);//30
            //Console.WriteLine(s3);//3

            //string metin = "Merhaba";
            //string metin2 = "C#";
            //Console.WriteLine(metin);
            //Console.WriteLine(metin2);
            //StringRef(ref metin, ref metin2);
            //Console.WriteLine(metin);
            //Console.WriteLine(metin2);

            //10 elemanlı bir dizimiz olacak isteyen metin isteyen sayı yapabilir
            //Bu yapı methoda gidecek ve  bu elemanların herbiri güncellenecek dışarı
            //cıktığında 15 değer olarak ekrana yazdıracağız.
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Çıkan değerler");
            //DiziGuncelle(ref sayilar);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            int sayi;
            int sayi2;
            //Console.WriteLine(sayi);//hata verir tanımlanmamış değerler
            //Console.WriteLine(sayi2);
            //Sayilar(out sayi, out sayi2);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //string metin = "1234";
            //int.TryParse(metin, out int x);
            //Console.WriteLine(x+1234);
            string d = "";
            string d2 = null;
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Metinler(out d, out d2);
            Console.WriteLine(d);
            Console.WriteLine(d2);

            int aziza = 123;
            int melek = 10;
            int can;

            int deger = OrtayaKarisik(aziza, ref melek, out can);

            Console.WriteLine(deger);
            Console.WriteLine(melek);
            Console.WriteLine(can);
            int[] dizi;
            Diziler(out dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

        }
        #region Ref Methodlar
        static void RefMethod(ref int sayi, ref int sayi2,int sayi3)//Params veya optional yapıdaki gibi son
                                                                    //parametre olma zorunluluğu yoktur
        {
            sayi = 20;
            sayi2 = 30;
            sayi3 = 40;
        }
        static void StringRef(ref string deger, ref string deger2)
        {
            deger = "Methodlara";
            deger2 = "Hoşgeldiniz";
        }
        static void DiziGuncelle(ref int[] dizi)
        {
            dizi = new int[15];
            int sayi = 20;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = sayi;
                sayi++;
            }
        }
        #endregion
        #region out methodlar
        static void Sayilar(out int x, out int y)
        {
            x = 100;
            y = 120;
        }
        static void Metinler(out string deger, out string deger2)
        {
            deger = "Merhaba";
            deger2 = "Out method";
        }
        static int OrtayaKarisik(int sayi, ref int sayi2, out int sayi3)
        {
            sayi2 = 20;
            sayi3 = 30;
            sayi = sayi2 + sayi3;
            return sayi;//return sadece bir değer dönderir out ile ref birden fazla değer dönderebilir.
        }
        static void Diziler(out int[] dizi)
        {
            dizi= new int[15];
            int sayi = 1;
            for (int i = 0; i < dizi.Length; i++) 
            { 
                dizi[i] += sayi;
                sayi++;
            }
           
        }
        #endregion

    }
}
