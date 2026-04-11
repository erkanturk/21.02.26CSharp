namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Karar Yapısı (Conditions) if else,switch case
             * If else
             * Karar yapılarından sadece bir tanesi çalışır bir yapıda birden fazla koşul olması durumunda 
             * Karar yapıları devreye girer ve koşul olarak hangisi true dönerse o blokdaki yapının içindeki kodlar çalışır.
             * Eğer hiçbir koşul uymazsa else yapısı devreye girer ve geriye kalan tüm koşullar için uygulanacak değeri yazar
             * Bir if else yapısında birden fazla else if yapısı barınır fakat if yapısı bir tane else yapısı birtane olmalıdır
             * If else yapısının içerisinde farklı if else yapılarıda barındıra biliriz.
             * !!!!Daima true olduğu sürecede çalışır.
             * Else yapısında bir koşul verilmez geriye kalan tüm değerleri kapsar.
             */
            #region Örnek1
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı sıfırdan büyüktür");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Girilen sayı sıfırdan küçüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı 0 a eşittir");
            //}
            #endregion
            #region örnek 2
            //Erkan hoca kurumda mı örneği
            //Console.WriteLine("1.Kata baktın mı ?");
            //string cevap1 = Console.ReadLine();
            //Console.WriteLine("2.Kata baktın mı ?");
            //string cevap2 = Console.ReadLine();
            //Console.WriteLine("3.kata baktın mı ?");
            //string cevap3 = Console.ReadLine();
            //Console.WriteLine("4.kata baktın mı ?");
            //string cevap4 = Console.ReadLine();
            //if (cevap1 != "Evet")
            //{
            //    Console.WriteLine("Erkan hoca 1. katta olabilir");
            //}
            //else if (cevap2 != "Evet")
            //{
            //    Console.WriteLine("Erkan hoca 2. katta olabilir");
            //}
            //else if (cevap3 != "Evet")
            //{
            //    Console.WriteLine("Erkan hoca 3. katta olabilir");
            //}
            //else if (cevap4 != "Evet")
            //{
            //    Console.WriteLine("Erkan hoca 4. katta olabilir");
            //}
            //else
            //{
            //    Console.WriteLine("Erkan hoca Kurumda olmayabilir");
            //}
            #endregion
            #region Örnek3
            //Kullanıcıdan bir sayı alınız bu sayının negatif mi pozitif mi olduğunu bulan karar yapısını yazınız
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı Pozitif: "+sayi);
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı negatif: "+sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0: "+sayi);
            //}
            #endregion
            #region Örnek 4 
            //Kullanıcıdan alınan sayının çift mi tek mi olduğunu nasıl buluruz ?
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 1)
            //{
            //    Console.WriteLine("Sayı tek");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı cift");
            //}
            //int sayi = 5;
            //int sayi2 = 10;
            //if (sayi > 0 && sayi2 > sayi)
            //{
            //    Console.WriteLine("En büyük sayı değeri: " + sayi2);
            //}
            //else if(sayi<0||sayi2>20)
            //{
            //    Console.WriteLine("sayı2 20 den büyük");
            //}
            #endregion
            #region Örnek5
            //string kad = "admin";
            //string pass= "admin";
            //// kullanıcıdan kullanıcı adı değeri alacağız ve sonra şifre isteyeceğiz
            ////sistemde sabit olarak kayıtlı olan kad ve pass değeri eğer uyuşuyorsa kullanıcının girdiği değere
            ////sisteme giriş başarılı desin
            ////eğer uyuşmuyorsa yanlış kullanıcı adı veya şifre desin
            //Console.WriteLine("Kullanıc Adı:");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();
            //if (kullaniciAdi == kad && pass == sifre)
            //{
            //    Console.WriteLine("Sisteme giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            //}

            #endregion
            #region Kullanıcı giriş işlemi
            string kullanici = "erkan";
            string sifre = "1453";
            Console.WriteLine("Kullanıcı Adınız:");
            string kad = Console.ReadLine();
            Console.WriteLine("Şifre:");
            string pass = Console.ReadLine();
            if ((kad == kullanici || kad == "erkan@gmail.com" || kad == "5385620687") && pass == sifre)
            {
                Console.WriteLine("Sisteme giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
                if ((kad != kullanici && kad != "erkan@gmail.com" && kad != "5385620687"))
                {
                    Console.WriteLine("Kullanıcı adı hatalı");
                    if (sifre != pass)
                    {
                        Console.WriteLine("Şifre hatalı");
                    }
                }
                else
                {
                    Console.WriteLine("Şifre hatalı");
                }
            }

            #endregion
        }
    }
}
