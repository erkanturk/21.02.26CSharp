namespace _06_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Switch Case (Koşul yapısı)
             * Gelen değere göre içindeki sabit case yapılarını kontrol eder eğer
             * Gelen koşula uyan bir case yapısı var ise içindeki kod bloğunu çalıştırır
             * Hiç bir case bloğu gelen koşulu karşılamıyor ise 
             * default kısmı çalışır
             * Her case bloğun da kod bitimini break ifadesi ile belirtmemiz gerekir
             * farklı durumlarda break ifadesi kullanmaya biliriz.
             */
            #region Plaka bulma
            //Console.WriteLine("Aradığınız şehrin Adını giriniz Plakasını bulunuz");
            //string sehir = Console.ReadLine();
            //switch (sehir)
            //{
            //    case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "İstanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "ankara": Console.WriteLine($"{sehir} plakası 06"); break;
            //    case "adana": Console.WriteLine($"{sehir} plakası 01"); break;
            //    case "bursa": Console.WriteLine($"{sehir} plakası 16"); break;
            //    case "hatay": Console.WriteLine($"{sehir} plakası 31"); break;
            //    case "amasya": Console.WriteLine($"{sehir} plakası 05"); break;
            //    case "tokat": Console.WriteLine($"{sehir} plakası 60"); break;
            //    case "düzce": Console.WriteLine($"{sehir} plakası 81"); break;
            //    case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
            //    default:
            //        Console.WriteLine("Sistemde yaşanan yoğunluktan dolayı bu bilgiye ulaşılamadı sonra tekrar deneyin");
            //        break;
            //}
            #endregion
            //Kullanıcıdan türkçe kelime girmesini isteyeceğiz kullanıcının girdiği türkçe kelimenin karşılığında
            //Console.WriteLine("Girdiğiniz {Merhaba} kelimenin karşılığı => Hello ")
            // bu yapı gibi ekranda yazacak.

            #region türkçe ingilizce
            //Console.WriteLine("Tükçe ingilizce Sözlüğe hoşgeldiniz.");
            //Console.WriteLine("Türkçe değer girin ingilizcesini öğrenin");
            //string kelime = Console.ReadLine();
            //switch (kelime)
            //{
            //    case "bulutlu": Console.WriteLine($"{kelime} ingilizcesi => cloudy"); break;
            //    case "güneşli": Console.WriteLine($"{kelime} ingilizcesi => sunny"); break;
            //    case "mavi": Console.WriteLine($"{kelime} ingilizcesi => blue"); break;
            //    case "gökyüzü": Console.WriteLine($"{kelime} ingilizcesi => sky"); break;
            //    case "eğer": Console.WriteLine($"{kelime} ingilizcesi => if"); break;
            //    case "kırmak": Console.WriteLine($"{kelime} ingilizcesi => break"); break;
            //    case "sayı": Console.WriteLine($"{kelime} ingilizcesi => number"); break;
            //    case "metin": Console.WriteLine($"{kelime} ingilizcesi => text"); break;
            //    default:
            //        Console.WriteLine("Aranan kelime sözlükte mevcut değil");
            //        break;
            //}
            #endregion

            #region Goto Case
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin\n1-Stok Eksilt\n2-Ürün Ekle\n3-Satış Yap");
            //string islemYap = Console.ReadLine();
            //switch (islemYap)
            //{
            //    case "1": Console.WriteLine("Stok Eksiltildi"); break;
            //    case "2": Console.WriteLine("Ürün başarı ile eklendi"); break;
            //    case "3": Console.WriteLine("Satış başarılı"); goto case "1";
            //    default:
            //        Console.WriteLine("Hatalı işlem");
            //        break;
            //}
            //bir atm programı 1 bakiye görüntüle 2 para yatır 3 para çek => 1 bakiye göster
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin\n1-Bakiye göster\n2-Para Yatır\n3-Para Çek");
            //string islemYap = Console.ReadLine();
            //switch (islemYap)
            //{
            //    case "1": Console.WriteLine("Bakiye gösterildi"); break;
            //    case "2": Console.WriteLine("Para Yatırıldı"); goto case "1";
            //    case "3": Console.WriteLine("Para Çekildi Güncel Bakiye"); goto case "1";
            //    default:
            //        Console.WriteLine("Hatalı işlem");
            //        break;
            //}
            #endregion
            #region Switch Case If Else
            //Console.WriteLine("Şehir gir plana öğren");
            //string sehir = Console.ReadLine();
            //switch (sehir)
            //{
            //    case "istanbul":
            //        Console.WriteLine($"{sehir} plakası 34");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap = Console.ReadLine();
            //        if (cevap == "trafik")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "ankara":
            //        Console.WriteLine($"{sehir} plakası 06");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap2 = Console.ReadLine();
            //        if (cevap2 == "aspava")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "adana":
            //        Console.WriteLine($"{sehir} plakası 01");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap3 = Console.ReadLine();
            //        if (cevap3 == "şırdan")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "bursa":
            //        Console.WriteLine($"{sehir} plakası 16");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap4 = Console.ReadLine();
            //        if (cevap4 == "iskender")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "hatay":
            //        Console.WriteLine($"{sehir} plakası 31");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap5 = Console.ReadLine();
            //        if (cevap5 == "künefe")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "amasya":
            //        Console.WriteLine($"{sehir} plakası 05");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap6 = Console.ReadLine();
            //        if (cevap6 == "elma")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "tokat":
            //        Console.WriteLine($"{sehir} plakası 60");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap7 = Console.ReadLine();
            //        if (cevap7 == "yaprak")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "düzce":
            //        Console.WriteLine($"{sehir} plakası 81");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap9 = Console.ReadLine();
            //        if (cevap9 == "fındık")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    case "izmir":
            //        Console.WriteLine($"{sehir} plakası 35");
            //        Console.WriteLine("Nesi meşur Bize yazın");
            //        string cevap10 = Console.ReadLine();
            //        if (cevap10 == "boyoz")
            //        {
            //            Console.WriteLine("Tebrikler doğru cevap");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Yanlış cevap");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Sistemde yaşanan yoğunluktan dolayı bu bilgiye ulaşılamadı sonra tekrar deneyin");
            //        break;
            //}

            #endregion
            //kullanıcıdan iki sayı girmesini isteyin
            //Kullanıcının girdiği ilk sayı değeri ve 
            //Kullanıcının girdiği ikinci sayı değerini matematiksel işleme tabi tutacağız
            //Kullanıcıya yapmak istediğiniz işlem diye soracağız
            //Kullanıcı + Toplama - Çıkarma * Çarpma / Bölme işlemlerini
            //Switch case yapısına gönderecek ve bu yapıda hangi işlem seçildi ise o matematik
            //işleminin sonucunu ekrana yazdıracak.
            #region Hesap Makinesi
            //Console.WriteLine("1.Sayı");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlem (+ - * / %)");
            //char islem = Convert.ToChar(Console.ReadLine());
            //switch (islem)
            //{
            //    case '+': Console.WriteLine($"Toplama işlemi Sonucu: {sayi + sayi2}"); break;
            //    case '-': Console.WriteLine($"Çıkartma işlemi Sonucu: {sayi - sayi2}"); break;
            //    case '*': Console.WriteLine($"Çarpma işlemi Sonucu: {sayi * sayi2}"); break;
            //    case '/': if (sayi2 > 0) Console.WriteLine(sayi / sayi2); else Console.WriteLine("hata"); break;
            //    case '%': Console.WriteLine($"Mod işlemi sonucu {sayi % sayi2}"); break;
            //    default: Console.WriteLine("hatalı işlem"); break;
            //}
            #endregion
            #region Ödev
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            #endregion

            //Kullanıcıdan alacaği kitap türünü isteyin 
            //Örneğin aksiyon kitabı alacak 
            //aksiyon kitabı reyonu a reyondadır diye ekrana yazı yazdırın
            //eğer kullanıcı ödeme derse kasa olan case yapısına gitsin ödeme yapıldı desin
            //Aksiyon Bilimkurgu Drama Dünya klasikleri Ödeme
            //Case"ödeme" Console.WriteLine("Kasaya yönlendiriliyorsun")
            //Case"kasa" Console.WriteLinet("Ödeme Alındı")

            Console.WriteLine("Kitap türünü belirtin");
            string kitap = Console.ReadLine();
            switch (kitap)
            {
                case "aksiyon": Console.WriteLine($"{kitap} a reyonundadır"); break;
                case "bilimkurgu": Console.WriteLine($"{kitap} b reyonundadır"); break;
                case "drama": Console.WriteLine($"{kitap} c reyonundadır"); break;
                case "dünya klasikleri": Console.WriteLine($"{kitap} d reyonundadır"); break;
                case "ödeme": Console.WriteLine("Kasaya yönlendiriliyorsunuz"); goto case "kasa";
                case "kasa": Console.WriteLine("Ödeme işlemi başarılı");break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;
            }
        }
    }
}
