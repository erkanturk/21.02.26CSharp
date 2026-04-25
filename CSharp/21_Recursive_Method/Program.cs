namespace _21_Recursive_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Recursive(Yineleyen) Method Yapısı
             * Büyük bir yapının tamanını yapmak yerine bu işi küçük parçalara bölüp her seferinde bir kısmı yapmaya
             * yarayan Yinelenen method yapısıdır.
             * Method koşullu bir biçimde kendi içerisinde tanımlanır ve bu doğrultuda koşula bağlı olarak 
             * Tekrar tekrar kendini çağırır
             * Recursive method yapısı örneğin 4 defa çağırmak istersek daima bir fazla çalışır 4 +1 olarak düşünmemiz gerekir.      
             */
            // Yaz();

            Console.WriteLine("Kayıt işlemleri Çoklu kayıt için 1 Tekli kayıt için 2 Döngü form 3");
            string deger = Console.ReadLine();
            if (deger == "1")
            {
                Console.WriteLine("Kaç Adet olsun");
                int sayi = Convert.ToInt32(Console.ReadLine());
                CokluForm(sayi);
            }
            else if (deger == "2")
            {
                Form();
            }
            else if (deger == "3") 
            {
                Console.WriteLine("Kaç Adet olsun");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Form2(sayi);
            }
        }
        //static void Yaz()//Hatalı kullanım örneği
        //{
        //    Console.WriteLine("Hata");
        //    Yaz();
        //}
        static void Form()
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Adınız:{ad} Soyadınız:{soyad} Yaşınız:{yas}");
        }

        static void Form2(int sayi)
        {
            string ad = "";

            string soyad = "";

            int yas = 0;
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Adınız");
                 ad = Console.ReadLine();
                Console.WriteLine("Soyad");
                 soyad = Console.ReadLine();
                Console.WriteLine("Yaş");
                 yas = Convert.ToInt32(Console.ReadLine());
            }
           

            Console.WriteLine($"Adınız:{ad} Soyadınız:{soyad} Yaşınız:{yas}");
        }
        static void CokluForm(int sayi)
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());

           
            if (sayi > 0)//LiFO Last in  First Out 
            {
                CokluForm(sayi - 1);
            }
            Console.WriteLine($"Adınız:{ad} Soyadınız:{soyad} Yaşınız:{yas}");
        }

    }
}
