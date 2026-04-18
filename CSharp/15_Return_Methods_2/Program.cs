namespace _15_Returns_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Bir method tanımlayacağız indirim diye kullanıcıdan 2 ürün fiyatı girmesini isteyeceğiz
            //Girilen fiyatlardan ucuz olana %30 indirim uygulayacağız ve kullanıcıya 3. üründe %50
            //İndirim olduğunu söyleyeceğiz kullanıcıdan alınan cevaba göre 3.ürüne yönlendireceğiz
            //Ve 3. ürünün fiyatını isteyeceğiz sonrasında 1.2.3 fiyatın her birinin toplam tutarları ekrana yazdırılacak.
            //eğer kullanıcı 3. ürüne gitmek istemezse 1. ve 2. ürünün toplam tutarını ekrana yazdıracağız
            #endregion
            #region Ödev2
            //Rasgele 1-100 arasında değer oluşturan ve bu değerler
            //15 değer tutan bir diziye aktaralım ve bu dizideki
            //Dizideki tek ve çift sayısına göre  dizilerin uzunluğu belli olacak ve 
            //tek ve çift sayıları ayrı ayrı diziye atayan method yazılacak.
            //Ve ekrana yazdıralım.
            #endregion
            //Bir işlem yapacağız bu işlem sonucunda gelen değeri kullanarak Main içerisinde bir yönlendirme yapacağız.
            Console.WriteLine("1.Sayı değeri");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı değeri");
            int m = Convert.ToInt32(Console.ReadLine());
            int sayi = Deger(n, m);
            if (sayi == 1)
            {
                Console.WriteLine(n / m);
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Bölen bölünenden büyük olamaz");
            }
            else if (sayi == -1)
            {
                Console.WriteLine("Bölen sıfır olamaz");
            }
            else if(sayi == 2)
            {
                Console.WriteLine("Sayılar birbirine eşittir.");
            }
        }

        static int Deger(int sayi, int sayi2)
        {

            if (sayi > sayi2 && sayi2 != 0)
            {
                return 1;
            }
            else if (sayi2 > sayi)
            {
                return 0;
            }
            else if (sayi2 == 0)
            {
                return -1;
            }
            else
            {
                return 2;
            }

        }
        //static void Deger2(int sayi, int sayi2)
        //{
        //    if (sayi > sayi2 && sayi2 != 0)
        //    {
        //        return 1;
        //    }
        //    else if (sayi2 > sayi)
        //    {
        //        return 0;
        //    }
        //    else if (sayi2 == 0)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 2;
        //    }
        //}
    }
}
