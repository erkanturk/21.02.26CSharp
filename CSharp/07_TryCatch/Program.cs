namespace _07_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi+10);
            /* TryCatch (Dene yakala)
             * Programın çalışma sırasında oluşabilecek hataları yakalayarak programın çökmesini engeller
             * Kullanıcı veya sistem kaynaklı hataları yakalayarak programın akışını bozmadan devam etmesini sağlar
             * Catch kısmı ise yakaladığı hataları loglamak yada hata durumunda yönlendirme yapmak için kullanılır
             * eğer bir kod bloğunda hata var ise doğrudan catch kısmı devreye girer 
             * fakat try catch syntax hatalarını yakalamaz.

            
            */
            #region Örnek 1
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(sayi + 10);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata: " + ex.Message);

            //}
            //Console.WriteLine("Hata olsa dahi program çökmedi ");

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi2 + 10);
            //Console.WriteLine("Hata yakalama yöntemi yok burası çalışmayacak");
            #endregion
            #region örnek 2
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("ikinci sayı ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi / sayi2);
            //    Console.WriteLine("Merhaba Try catch");

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sıfıra bölünme hatası: " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format hatası: " + ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Miktar aşımı:" + ex.Message);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Genel tüm hatalar: " + e.Message);
            //}
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("ikinci sayı ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi / sayi2);
            //    Console.WriteLine("Merhaba Try catch");

            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Genel tüm hatalar: " + e.Message);
            //}
            #endregion
            #region Örnek 3
            //try
            //{
            //    Console.WriteLine("Cinsiyet belirtiniz");
            //    string cinsiyet = Console.ReadLine().ToUpper();
            //    switch (cinsiyet)
            //    {
            //        case "ERKEK":
            //            Console.WriteLine("Yaşınız");
            //            int yas = Convert.ToInt32(Console.ReadLine());
            //            if (yas >= 60)
            //            {
            //                Console.WriteLine("Maaşınız");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Emekli ikramiyeniz: {maas * 10}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayınız");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim >= 6000)
            //                {
            //                    Console.WriteLine("Maaşınız");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine($"Emekli ikramiyeniz:{maas * 11}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu");
            //                }
            //            }
            //            break;
            //        case "KADIN":
            //            Console.WriteLine("Yaşınız");
            //            int kYas = Convert.ToInt32(Console.ReadLine());
            //            if (kYas >= 58)
            //            {
            //                Console.WriteLine("Maaşınız");
            //                double maas = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine($"Emekli ikramiyeniz: {maas * 10}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Prim gün sayınız");
            //                int prim = Convert.ToInt32(Console.ReadLine());
            //                if (prim >= 5800)
            //                {
            //                    Console.WriteLine("Maaşınız");
            //                    double maas = Convert.ToDouble(Console.ReadLine());
            //                    Console.WriteLine($"Emekli ikramiyeniz:{maas * 11}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Emeklilik yalan oldu");
            //                }
            //            }
            //            break;
            //        default: Console.WriteLine("Hatalı işlem"); break;

            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Hata");
            //}
            #endregion
            #region Örnek 4
            //Console.WriteLine("Bağlantı açıldı");
            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{
            //    Console.WriteLine("Her koşulda çalışırım");
            //    Console.WriteLine("Bağlantı kapatıldı");
            //}
            #endregion
            #region  Örnek 5
            // Kullanıcıdan 2 sayı değeri alacağız aldığımız bu değerleri 
            // kullanıcıya yapmak istediğiniz işlem nedir diye sorarak işleme tabi tutacağız
            // Toplama + Çıkarma - Çarpma * Bölme gibi senaryolarımız olacak 
            //Kullanıcı hata yaparsa sistem çalışmaya devam edecek program patlamayacak 
            //En sonda hata verse bile sistem çalışıyor yazısı görünecek .

            try
            {
                Console.WriteLine("1.Sayı");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayı");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yapmak istediğiniz işlem");
                string islem = Console.ReadLine();
                if (islem == "+")
                {
                    Console.WriteLine(sayi + sayi2);
                }
                else if (islem == "*")
                {
                    Console.WriteLine(sayi * sayi2);
                }
                else if (islem == "-")
                {
                    Console.WriteLine(sayi - sayi2);
                }
                else if (islem == "/")
                {
                    Console.WriteLine(sayi/sayi2);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Hata");
            }
            finally
            {
                Console.WriteLine("Sistem çalışmaya devam ediyor");
            }
            Console.WriteLine("İşlem tamamlandı");
            #endregion

        }
    }
}
