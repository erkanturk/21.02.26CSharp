namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programlama dilleri büyük küçüğe duyarlı yapılardır  Örneğin A değeri a değerine eşit değildir.
             * Programlama dilinde kullanıcı tarafından gelen her değer metinseldir.
             * C# data protected bir dildir yani veri korumalı bir dildir.
             * Değişken isimleri benzersiz olmalıdır.
            */
            //Metinsel tip
            //string metinsel veri tipidir
            string ad = "Erkan";//Değişkenler verileri taşımak ve depolamak için kullanılır 
            string soyad = "Türk";//ihtiyac durumunda bu değerleri kullanırız
            string sayi = "10";//Metin değerinin içerisinde sayı da olsa toplama işlemi yapamayız
            string sayi2 = "10";//metinsel değerlerde + ile birleştirme yapılır toplanamaz.
            Console.WriteLine(sayi + sayi2);
            Console.WriteLine(ad + soyad);

            //Tek değer
            char harf = 'A';//char tek bir değer taşıyabilir ve sayısal karşılığı vardır.
            //Örneğin cinsiyet E K olarak tek değer yada tl '₺' değeri gibi yapılarda kullanılır.
            Console.WriteLine(harf);
            char harf2 = 'a';
            Console.WriteLine(harf + harf2);//Char değerler ascii table da sayısal karşılığı olduğu için toplama işleminde
            //iki char değerinin decimal sayılarını toplar.

            //Nesnesel veri tipi
            object nesne = "Erkan";//Obje ise her değeri nesne olarak tutar. içerisinde her veriyi tutabilir.
            object harfler = 'B';
            object sayi3 = 10;
            //Variable veri tipi
            var metin = "Yakup";
            var number = 10;
            var tekHarf = 'C';

            //true(doğru) false(yanlış)
            bool dogru = true;
            bool yanlis = false;

            //Sayısal tipler
            byte enKucukTamSayi = 123;
            int tamSayi = 123;
            long enBuyukTamSayi = 123;
            //Ondalıklı sayılar
            float enkucukOndalikli = 123.45f;//float değerlerde f ile tanımlama yaparız.
            double ortaOndalikli = 123.456;//ondalıklı sayı;
            decimal enBuyukOndalikli = 123.456m;//en büyük ondalıklı sayı

            //$ işareti string interpolation yazma yöntemi
            Console.WriteLine($"byte minimum {byte.MinValue} maksimum {byte.MaxValue}");
            Console.WriteLine($"int minimum {int.MinValue} maksimum {int.MaxValue}");
            Console.WriteLine($"long minimum {long.MinValue} maksimum {long.MaxValue}");
            Console.WriteLine($"float minimum {float.MinValue} maksimum {float.MaxValue}");
            Console.WriteLine($"double minimum {double.MinValue} maksimum {double.MaxValue}");
            Console.WriteLine($"decimal minimum {decimal.MinValue} maksimum {decimal.MaxValue}");

            Console.WriteLine(tamSayi);//güncelleme öncesi 
            tamSayi = 456;//bir değişkenin içerisindeki değeri güncelleme yöntemi 
            Console.WriteLine(tamSayi);//Güncelleme sonrası


            //iki int değişken tanımlayalım bu değişkenlere değer ataması yapacağız
            //ve bu değerleri matematiksel işleme
            //tabi tutup değişkenlere verdiğimiz değerlerin sonucunu ekrana yazdıralım

            double deger = 77;
            double deger2 = 88.33;
            Console.WriteLine($"Toplama sonucu:{deger + deger2}");
            double deger3 = 125;
            double deger4 = 8;
            Console.WriteLine($"Bölme işlemi sonucu: {deger3 / deger4}");
            double deger5 = 123;
            double deger6 = 123;
            Console.WriteLine($"Çarpma işlemi sonucu: {deger5 * deger6}");
            double deger7 = 2011;
            double deger8 = 2026;
            Console.WriteLine($"Çıkarma işlemi sonucu: {deger8 - deger7}");

            //Zaman tipleri
            DateTime zaman = DateTime.Now;//Şimdiki zaman
            Console.WriteLine(zaman);
            Console.WriteLine(zaman.Year);//Yıl değerini al
            Console.WriteLine(zaman.Month);//Ay değeri
            Console.WriteLine(zaman.Day);
            Console.WriteLine(zaman.Hour);
            Console.WriteLine(zaman.Minute);
            Console.WriteLine(zaman.Second);
            Console.WriteLine(zaman.Millisecond);
            //Formatlı tarih zaman yapısı
            Console.WriteLine(zaman.ToString("yyyy-MM-dd HH:mm:ss:ff"));


        }
    }
}
